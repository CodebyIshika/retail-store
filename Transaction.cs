using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    public class Transaction
    {
        private Product purchasedProduct;
        private int quantity;

        public Transaction(Product product, int quantity)
        {
            this.purchasedProduct = product;
            this.quantity = quantity;

            Program.UserTransactions.Add(this);
        }

        public Product PurchasedProduct => purchasedProduct;
        public int Quantity => quantity;

        public void ProcessTransaction()
        {
            // Check if there is sufficient quantity available
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
                Console.WriteLine($"Error: Insufficient quantity available for {purchasedProduct.ProductName}.");
                Console.WriteLine("");
            }
        }

        public static void DisplayTransactions(List<Transaction> transactions)
        {
            Console.WriteLine("Transactions History:");
            Console.WriteLine();
            var uniqueTransactions = transactions.Distinct().ToList();
            foreach (var transaction in uniqueTransactions)
            {
                double totalAmount = transaction.PurchasedProduct.PriceOfProduct * transaction.Quantity;
                double discountAmount = transaction.PurchasedProduct.Discount(transaction.PurchasedProduct.PriceOfProduct);
                double finalAmount = totalAmount - discountAmount;
                Console.WriteLine($"Product: {transaction.PurchasedProduct.ProductName}, Quantity: {transaction.Quantity}, Final Amount: {finalAmount:C}");
            }
            Console.WriteLine();
        }
    }
}
