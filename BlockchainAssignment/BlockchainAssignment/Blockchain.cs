using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockchainAssignment
{
    class Blockchain
    {
        // List of block objects forming the blockchain
        public List<Block> blocks;

        // Maximum number of transactions per block
        private int transactionsPerBlock = 5;

        // List of pending transactions to be mined
        public List<Transaction> transactionPool = new List<Transaction>();

        // Default Constructor - initializes the list of blocks and generates the genesis block
        public Blockchain()
        {
            blocks = new List<Block>()
            {
                new Block() // Create and append the Genesis Block
            };
        }

        // Prints the block at the specified index to the UI
        public string GetBlockAsString(int index)
        {
            // Check if referenced block exists
            if (index >= 0 && index < blocks.Count)
                return blocks[index].ToString(); // Return block as a string
            else
                return "No such block exists";
        }

        // Retrieves the most recently appended block in the blockchain
        public Block GetLastBlock()
        {
            return blocks[blocks.Count - 1];
        }

        private static Random rng = new Random(); // A single instance of Random for the class

        // Retrieve pending transactions and remove from pool, with options to sort by various criteria
        public List<Transaction> GetPendingTransactions(bool sortByFee = false, bool sortByWaitTime = false, bool randomSelection = false, string ownerAddress = null)
        {
            if (sortByFee)
            {
                transactionPool = transactionPool.OrderByDescending(t => t.fee).ToList();
            }
            else if (sortByWaitTime)
            {
                transactionPool = transactionPool.OrderBy(t => t.Timestamp).ToList();
            }
            else if (randomSelection)
            {
                transactionPool = transactionPool.OrderBy(t => rng.Next()).ToList();
            }
            else if (ownerAddress != null)
            {
                // Sort so that transactions from the owner's address are first
                transactionPool = transactionPool.OrderByDescending(t => t.senderAddress == ownerAddress).ThenBy(t => t.Timestamp).ToList();
            }

            int n = Math.Min(transactionsPerBlock, transactionPool.Count);
            List<Transaction> transactions = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);
            return transactions;
        }

        // Add a new block to the blockchain
        public void AddBlock(Block block, bool sortByFee = false)
        {
            // Sort pending transactions by fee if needed
            if (sortByFee)
            {
                transactionPool = transactionPool.OrderByDescending(t => t.fee).ToList();
            }

            // Add the block to the blockchain
            blocks.Add(block);
        }

        // Check validity of a block's hash by recomputing the hash and comparing with the mined value
        public static bool ValidateHash(Block b)
        {
            string rehash = b.CreateHash();
            return rehash.Equals(b.hash);
        }

        // Check validity of the Merkle root by recalculating the root and comparing with the mined value
        public static bool ValidateMerkleRoot(Block b)
        {
            string reMerkle = Block.MerkleRoot(b.transactionList);
            return reMerkle.Equals(b.merkleRoot);
        }

        // Check the balance associated with a wallet based on the public key
        public double GetBalance(string address)
        {
            // Accumulator value
            double balance = 0;

            // Loop through all approved transactions in order to assess account balance
            foreach (Block b in blocks)
            {
                foreach (Transaction t in b.transactionList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount; // Credit funds received
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee); // Debit payments placed
                    }
                }
            }
            return balance;
        }

        // Output all blocks of the blockchain as a string
        public override string ToString()
        {
            return string.Join("\n", blocks);
        }
    }
}
