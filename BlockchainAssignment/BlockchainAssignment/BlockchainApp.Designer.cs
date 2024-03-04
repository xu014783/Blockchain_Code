﻿namespace BlockchainAssignment
{
    partial class chkSortByFee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockNo = new System.Windows.Forms.TextBox();
            this.generateWallet = new System.Windows.Forms.Button();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.TextBox();
            this.privateKey = new System.Windows.Forms.TextBox();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createTransaction = new System.Windows.Forms.Button();
            this.fee = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.reciever = new System.Windows.Forms.TextBox();
            this.recieverKeyLabel = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.printBlockchain = new System.Windows.Forms.Button();
            this.readPendingTransactions = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBalance = new System.Windows.Forms.Button();
            this.currentWalletLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.blocksLabel = new System.Windows.Forms.Label();
            this.validationLabel = new System.Windows.Forms.Label();
            this.CheckBoxFee = new System.Windows.Forms.CheckBox();
            this.CheckBoxWaitTime = new System.Windows.Forms.CheckBox();
            this.CheckBoxRandom = new System.Windows.Forms.CheckBox();
            this.CheckBoxOwnerPreference = new System.Windows.Forms.CheckBox();
            this.OwnerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blockTimeSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.blockTimeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.InfoText;
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(16, 14);
            this.output.Margin = new System.Windows.Forms.Padding(4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(612, 274);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(636, 79);
            this.printBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(88, 31);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Block #";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.PrintBlock_Click);
            // 
            // blockNo
            // 
            this.blockNo.Location = new System.Drawing.Point(730, 84);
            this.blockNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blockNo.Name = "blockNo";
            this.blockNo.Size = new System.Drawing.Size(31, 22);
            this.blockNo.TabIndex = 2;
            // 
            // generateWallet
            // 
            this.generateWallet.Location = new System.Drawing.Point(34, 329);
            this.generateWallet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateWallet.Name = "generateWallet";
            this.generateWallet.Size = new System.Drawing.Size(106, 67);
            this.generateWallet.TabIndex = 3;
            this.generateWallet.Text = "Generate New Wallet";
            this.generateWallet.UseVisualStyleBackColor = true;
            this.generateWallet.Click += new System.EventHandler(this.GenerateWallet_Click);
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(150, 344);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(70, 16);
            this.publicKeyLabel.TabIndex = 4;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(145, 370);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(75, 16);
            this.privateKeyLabel.TabIndex = 5;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // publicKey
            // 
            this.publicKey.Location = new System.Drawing.Point(225, 339);
            this.publicKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(251, 22);
            this.publicKey.TabIndex = 6;
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(228, 365);
            this.privateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(248, 22);
            this.privateKey.TabIndex = 7;
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(489, 337);
            this.validateKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(116, 27);
            this.validateKeys.TabIndex = 8;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.ValidateKeys_Click);
            // 
            // createTransaction
            // 
            this.createTransaction.Location = new System.Drawing.Point(635, 215);
            this.createTransaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(260, 32);
            this.createTransaction.TabIndex = 9;
            this.createTransaction.Text = "Create Transaction";
            this.createTransaction.UseVisualStyleBackColor = true;
            this.createTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(850, 165);
            this.fee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(47, 22);
            this.fee.TabIndex = 13;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(739, 165);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(47, 22);
            this.amount.TabIndex = 12;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(812, 167);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(31, 16);
            this.feeLabel.TabIndex = 11;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(676, 167);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 16);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.Text = "Amount";
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(739, 190);
            this.reciever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(158, 22);
            this.reciever.TabIndex = 15;
            // 
            // recieverKeyLabel
            // 
            this.recieverKeyLabel.AutoSize = true;
            this.recieverKeyLabel.Location = new System.Drawing.Point(644, 192);
            this.recieverKeyLabel.Name = "recieverKeyLabel";
            this.recieverKeyLabel.Size = new System.Drawing.Size(88, 16);
            this.recieverKeyLabel.TabIndex = 14;
            this.recieverKeyLabel.Text = "Reciever Key";
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(637, 41);
            this.newBlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(261, 32);
            this.newBlock.TabIndex = 16;
            this.newBlock.Text = "Generate New Block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.NewBlock_Click);
            // 
            // printBlockchain
            // 
            this.printBlockchain.Location = new System.Drawing.Point(766, 79);
            this.printBlockchain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printBlockchain.Name = "printBlockchain";
            this.printBlockchain.Size = new System.Drawing.Size(132, 31);
            this.printBlockchain.TabIndex = 17;
            this.printBlockchain.Text = "Entire Chain";
            this.printBlockchain.UseVisualStyleBackColor = true;
            this.printBlockchain.Click += new System.EventHandler(this.ReadAll_Click);
            // 
            // readPendingTransactions
            // 
            this.readPendingTransactions.Location = new System.Drawing.Point(634, 256);
            this.readPendingTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readPendingTransactions.Name = "readPendingTransactions";
            this.readPendingTransactions.Size = new System.Drawing.Size(261, 31);
            this.readPendingTransactions.TabIndex = 18;
            this.readPendingTransactions.Text = "Read Pending Transactions";
            this.readPendingTransactions.UseVisualStyleBackColor = true;
            this.readPendingTransactions.Click += new System.EventHandler(this.PrintPendingTransactions_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(634, 339);
            this.validate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(261, 57);
            this.validate.TabIndex = 19;
            this.validate.Text = "Full Blockchain Validation";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // checkBalance
            // 
            this.checkBalance.Location = new System.Drawing.Point(489, 366);
            this.checkBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBalance.Name = "checkBalance";
            this.checkBalance.Size = new System.Drawing.Size(116, 30);
            this.checkBalance.TabIndex = 20;
            this.checkBalance.Text = "Check Balance";
            this.checkBalance.UseVisualStyleBackColor = true;
            this.checkBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // currentWalletLabel
            // 
            this.currentWalletLabel.AutoSize = true;
            this.currentWalletLabel.Location = new System.Drawing.Point(36, 306);
            this.currentWalletLabel.Name = "currentWalletLabel";
            this.currentWalletLabel.Size = new System.Drawing.Size(90, 16);
            this.currentWalletLabel.TabIndex = 22;
            this.currentWalletLabel.Text = "Current Wallet";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(633, 136);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(85, 16);
            this.transactionLabel.TabIndex = 23;
            this.transactionLabel.Text = "Transactions";
            // 
            // blocksLabel
            // 
            this.blocksLabel.AutoSize = true;
            this.blocksLabel.Location = new System.Drawing.Point(636, 15);
            this.blocksLabel.Name = "blocksLabel";
            this.blocksLabel.Size = new System.Drawing.Size(48, 16);
            this.blocksLabel.TabIndex = 24;
            this.blocksLabel.Text = "Blocks";
            // 
            // validationLabel
            // 
            this.validationLabel.AutoSize = true;
            this.validationLabel.Location = new System.Drawing.Point(636, 308);
            this.validationLabel.Name = "validationLabel";
            this.validationLabel.Size = new System.Drawing.Size(67, 16);
            this.validationLabel.TabIndex = 25;
            this.validationLabel.Text = "Validation";
            // 
            // CheckBoxFee
            // 
            this.CheckBoxFee.AutoSize = true;
            this.CheckBoxFee.Location = new System.Drawing.Point(904, 48);
            this.CheckBoxFee.Name = "CheckBoxFee";
            this.CheckBoxFee.Size = new System.Drawing.Size(179, 20);
            this.CheckBoxFee.TabIndex = 27;
            this.CheckBoxFee.Text = "Sort Transactions by Fee";
            this.CheckBoxFee.UseVisualStyleBackColor = true;
            this.CheckBoxFee.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CheckBoxWaitTime
            // 
            this.CheckBoxWaitTime.AutoSize = true;
            this.CheckBoxWaitTime.Location = new System.Drawing.Point(904, 74);
            this.CheckBoxWaitTime.Name = "CheckBoxWaitTime";
            this.CheckBoxWaitTime.Size = new System.Drawing.Size(182, 20);
            this.CheckBoxWaitTime.TabIndex = 28;
            this.CheckBoxWaitTime.Text = "Sort Transactions by Wait";
            this.CheckBoxWaitTime.UseVisualStyleBackColor = true;
            this.CheckBoxWaitTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckBoxRandom
            // 
            this.CheckBoxRandom.AutoSize = true;
            this.CheckBoxRandom.Location = new System.Drawing.Point(904, 100);
            this.CheckBoxRandom.Name = "CheckBoxRandom";
            this.CheckBoxRandom.Size = new System.Drawing.Size(207, 20);
            this.CheckBoxRandom.TabIndex = 29;
            this.CheckBoxRandom.Text = "Sort Transactions by Random";
            this.CheckBoxRandom.UseVisualStyleBackColor = true;
            // 
            // CheckBoxOwnerPreference
            // 
            this.CheckBoxOwnerPreference.AutoSize = true;
            this.CheckBoxOwnerPreference.Location = new System.Drawing.Point(904, 126);
            this.CheckBoxOwnerPreference.Name = "CheckBoxOwnerPreference";
            this.CheckBoxOwnerPreference.Size = new System.Drawing.Size(193, 20);
            this.CheckBoxOwnerPreference.TabIndex = 30;
            this.CheckBoxOwnerPreference.Text = "Sort Transactions by Owner";
            this.CheckBoxOwnerPreference.UseVisualStyleBackColor = true;
            // 
            // OwnerAddressTextBox
            // 
            this.OwnerAddressTextBox.Location = new System.Drawing.Point(946, 189);
            this.OwnerAddressTextBox.Name = "OwnerAddressTextBox";
            this.OwnerAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.OwnerAddressTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Address Preference";
            // 
            // blockTimeSelector
            // 
            this.blockTimeSelector.Location = new System.Drawing.Point(936, 225);
            this.blockTimeSelector.Name = "blockTimeSelector";
            this.blockTimeSelector.Size = new System.Drawing.Size(120, 22);
            this.blockTimeSelector.TabIndex = 33;
            // 
            // chkSortByFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 402);
            this.Controls.Add(this.blockTimeSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OwnerAddressTextBox);
            this.Controls.Add(this.CheckBoxOwnerPreference);
            this.Controls.Add(this.CheckBoxRandom);
            this.Controls.Add(this.CheckBoxWaitTime);
            this.Controls.Add(this.CheckBoxFee);
            this.Controls.Add(this.validationLabel);
            this.Controls.Add(this.blocksLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.currentWalletLabel);
            this.Controls.Add(this.checkBalance);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readPendingTransactions);
            this.Controls.Add(this.printBlockchain);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.recieverKeyLabel);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.createTransaction);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.generateWallet);
            this.Controls.Add(this.blockNo);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.output);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "chkSortByFee";
            this.Text = "Blockchain App";
            ((System.ComponentModel.ISupportInitialize)(this.blockTimeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockNo;
        private System.Windows.Forms.Button generateWallet;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.TextBox publicKey;
        private System.Windows.Forms.TextBox privateKey;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Label recieverKeyLabel;
        private System.Windows.Forms.Button newBlock;
        private System.Windows.Forms.Button printBlockchain;
        private System.Windows.Forms.Button readPendingTransactions;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button checkBalance;
        private System.Windows.Forms.Label currentWalletLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label blocksLabel;
        private System.Windows.Forms.Label validationLabel;
        private System.Windows.Forms.CheckBox CheckBoxFee;
        private System.Windows.Forms.CheckBox CheckBoxWaitTime;
        private System.Windows.Forms.CheckBox CheckBoxRandom;
        private System.Windows.Forms.CheckBox CheckBoxOwnerPreference;
        private System.Windows.Forms.TextBox OwnerAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown blockTimeSelector;
    }
}

