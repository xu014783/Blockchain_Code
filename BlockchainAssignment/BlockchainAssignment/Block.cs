using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        /* Block Variables */
        private DateTime timestamp; // Time of creation

        // Added: Mining start and end times for block time measurement
        private DateTime miningStartTime;
        private DateTime miningEndTime;

        private int index, // Position of the block in the sequence of blocks
            difficulty = 4; // An arbitrary number of 0's to precede a hash value

        public String prevHash, // A reference pointer to the previous block
            hash, // The current block's "identity"
            merkleRoot, // The merkle root of all transactions in the block
            minerAddress; // Public Key (Wallet Address) of the Miner

        public List<Transaction> transactionList; // List of transactions in this block

        // Proof-of-work
        public long nonce; // Number used once for Proof-of-Work and mining

        // Rewards
        public double reward; // Simple fixed reward established by "Coinbase"

        /* Genesis block constructor */
        public Block()
        {
            timestamp = DateTime.Now;
            index = 0;
            transactionList = new List<Transaction>();

            // Record the start time before mining begins
            miningStartTime = DateTime.Now;

            hash = Mine();

            // Record the end time after mining
            miningEndTime = DateTime.Now;
        }

        /* New Block constructor */
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            timestamp = DateTime.Now;
            index = lastBlock.index + 1;
            prevHash = lastBlock.hash;
            this.minerAddress = minerAddress;
            reward = 1.0;
            transactions.Add(createRewardTransaction(transactions));
            transactionList = new List<Transaction>(transactions);
            merkleRoot = MerkleRoot(transactionList);

            // Record the start time before mining begins
            miningStartTime = DateTime.Now;

            hash = Mine();

            // Record the end time after mining
            miningEndTime = DateTime.Now;
        }

        /* Hashes the entire Block object */
        public String CreateHash()
        {
            String hash = String.Empty;
            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp.ToString() + index + prevHash + nonce + merkleRoot;
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
                hash += String.Format("{0:x2}", x);
            return hash;
        }

        // Create a Hash which satisfies the difficulty level required for PoW
        public String Mine()
        {
            nonce = 0; // Initalise the nonce
            String hash = CreateHash();
            String re = new string('0', difficulty);
            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }
            return hash;
        }

        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if (hashes.Count == 0) return String.Empty;
            if (hashes.Count == 1) return HashCode.HashTools.combineHash(hashes[0], hashes[0]);
            while (hashes.Count != 1)
            {
                List<String> merkleLeaves = new List<String>();
                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i == hashes.Count - 1)
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i]));
                    else
                        merkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i + 1]));
                }
                hashes = merkleLeaves;
            }
            return hashes[0];
        }

        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            double fees = transactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            return new Transaction("Mine Rewards", minerAddress, (reward + fees), 0, "");
        }

        // Calculate and return block mining time
        public TimeSpan GetMiningDuration()
        {
            return miningEndTime - miningStartTime;
        }

        /* Concatenate all properties to output to the UI */
        public override string ToString()
        {
            var miningDuration = GetMiningDuration();
            string blockInfo = "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timestamp
                + "\nPrevious Hash: " + prevHash
                + "\n-- PoW --"
                + "\nDifficulty Level: " + difficulty
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiners Address: " + minerAddress
                + "\n-- " + transactionList.Count + " Transactions --"
                + "\nMerkle Root: " + merkleRoot
                + "\nMining Duration: " + miningDuration.TotalSeconds + " seconds"; // Display mining duration

            // Append each transaction's details
            foreach (Transaction transaction in transactionList)
            {
                blockInfo += "\n" + transaction.ToString();
            }

            blockInfo += "\n[BLOCK END]";
            return blockInfo;
        }
    }
}
