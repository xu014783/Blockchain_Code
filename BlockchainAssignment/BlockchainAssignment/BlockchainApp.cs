using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class chkSortByFee : Form
    {
        private Blockchain blockchain;

        public chkSortByFee()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            UpdateText("New blockchain initialised!");
        }

        private void UpdateText(String text)
        {
            output.Text = text;
        }

        private void ReadAll_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.ToString());
        }

        private void PrintBlock_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockNo.Text, out int index) && index < blockchain.blocks.Count)
            {
                Block block = blockchain.blocks[index];
                string blockDetails = block.ToString();
                TimeSpan miningDuration = block.GetMiningDuration();
                blockDetails += $"\nMining Duration: {miningDuration.TotalSeconds} seconds";
                UpdateText(blockDetails);
            }
            else
            {
                UpdateText("Invalid Block No.");
            }
        }

        private void PrintPendingTransactions_Click(object sender, EventArgs e)
        {
            UpdateText(String.Join("\n", blockchain.transactionPool));
        }

        private void GenerateWallet_Click(object sender, EventArgs e)
        {
            Wallet.Wallet myNewWallet = new Wallet.Wallet(out string privKey);
            publicKey.Text = myNewWallet.publicID;
            privateKey.Text = privKey;
        }

        private void ValidateKeys_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(privateKey.Text, publicKey.Text))
                UpdateText("Keys are valid");
            else
                UpdateText("Keys are invalid");
        }

        private void CheckBalance_Click(object sender, EventArgs e)
        {
            UpdateText(blockchain.GetBalance(publicKey.Text).ToString() + " Assignment Coin");
        }

        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(publicKey.Text, reciever.Text, Double.Parse(amount.Text), Double.Parse(fee.Text), privateKey.Text);
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        private void NewBlock_Click(object sender, EventArgs e)
        {
            bool sortByFee = CheckBoxFee.Checked;
            bool sortByWaitTime = CheckBoxWaitTime.Checked;
            bool randomSelection = CheckBoxRandom.Checked;
            string ownerAddress = null;
            if (CheckBoxOwnerPreference.Checked)
            {
                ownerAddress = OwnerAddressTextBox.Text;
            }

            List<Transaction> transactions = blockchain.GetPendingTransactions(sortByFee, sortByWaitTime, randomSelection, ownerAddress);

            Block newBlock = new Block(blockchain.GetLastBlock(), transactions, publicKey.Text);
            blockchain.blocks.Add(newBlock);

            UpdateText("New block added to the blockchain.");
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            if (blockchain.blocks.Count == 1)
            {
                if (!Blockchain.ValidateHash(blockchain.blocks[0]))
                    UpdateText("Blockchain is invalid");
                else
                    UpdateText("Blockchain is valid");
                return;
            }

            for (int i = 1; i < blockchain.blocks.Count; i++)
            {
                if (blockchain.blocks[i].prevHash != blockchain.blocks[i - 1].hash ||
                    !Blockchain.ValidateHash(blockchain.blocks[i]) ||
                    !Blockchain.ValidateMerkleRoot(blockchain.blocks[i]))
                {
                    UpdateText("Blockchain is invalid");
                    return;
                }
            }
            UpdateText("Blockchain is valid");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
