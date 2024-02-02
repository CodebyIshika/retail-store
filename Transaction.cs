using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    // Transaction class represents a purchase transaction for a specific product and quantity
    public class Transaction
    {
        private Product purchasedProduct; // The product being purchased
        private int quantity;

        // Constructor 
        public Transaction(Product product, int quantity)
        {
            this.purchasedProduct = product;
            this.quantity = quantity;

            // Add the transaction to the transaction history only if there is sufficient quantity
            if (quantity <= purchasedProduct.QuantityOfProduct)
            {
                Program.UserTransactions.Add(this);
            }    
        }


        public Product PurchasedProduct => purchasedProduct;
        public int Quantity => quantity;

        // Process the transaction, updating inventory and displaying details
        public void ProcessTransaction()
        {
            try
            {
                // Check if there is sufficient quantity available in the inventory
                if (quantity <= purchasedProduct.QuantityOfProduct)
                {
                    // Update the inventory by subtracting the sold quantity
                    purchasedProduct.QuantityOfProduct -= quantity;

                    // Display transaction details
                    Console.WriteLine();
                    Console.WriteLine($"Transaction Details: {quantity} units of {purchasedProduct.ProductName}");
                    Console.WriteLine($"Total Amount: {purchasedProduct.PriceOfProduct * quantity:C}");
                    Console.WriteLine($"Discount Applied: {purchasedProduct.Discount(purchasedProduct.PriceOfProduct):C}");
                    Console.WriteLine($"Final Amount: {purchasedProduct.PriceOfProduct * quantity - purchasedProduct.Discount(purchasedProduct.PriceOfProduct):C}");
                    Console.WriteLine("");

                    // Add the transaction to the transaction history
                    Program.UserTransactions.Add(this);
                }
                else
                {
                    throw new Exception($"Insufficient quantity available for {purchasedProduct.ProductName}.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Display a list of unique transactions in the transaction history
        public static void DisplayTransactions(List<Transaction> transactions)
        {
            Console.WriteLine("Transactions History:");
            Console.WriteLine();
            var uniqueTransactions = transactions.Distinct().ToList();
            foreach (var transaction in uniqueTransactions)
            {
                // Calculate the final amount for each transaction
                double totalAmount = transaction.PurchasedProduct.PriceOfProduct * transaction.Quantity;
                double discountAmount = transaction.PurchasedProduct.Discount(transaction.PurchasedProduct.PriceOfProduct);
                double finalAmount = totalAmount - discountAmount;

                // Display transaction details
                Console.WriteLine($"Product: {transaction.PurchasedProduct.ProductName}, Quantity: {transaction.Quantity}, Final Amount: {finalAmount:C}");
            }
            Console.WriteLine();
        }
    }
}
