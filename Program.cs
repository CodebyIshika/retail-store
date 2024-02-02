using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    internal class Program
    {
        private static Inventory storeInventoryObj = new Inventory();
        private static List<Transaction> userTransactions = new List<Transaction>();

        public static List<Transaction> UserTransactions => userTransactions;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("|       Welcome to Retail Store          |");
                    Console.WriteLine(" ---------------------------------------- ");
                    Console.WriteLine("| 1. Add Product to Inventory ");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("| 2. Display Current Inventory");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("| 3. Process Transaction");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("| 4. Display Transactions");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine("| 5. Exit");
                    Console.WriteLine(" ----------------------------------------");
                    Console.WriteLine();
                    Console.Write("Enter your choice (1-5): ");
                    int userChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (userChoice)
                    {
                        case 1:
                            Console.Clear();
                            AddProductToInventory();
                            break;

                        case 2:
                            Console.Clear();
                            storeInventoryObj.DisplayInventory();
                            break;

                        case 3:
                            Console.Clear();
                            ProcessTransaction();
                            break;

                        case 4:
                            Console.Clear();
                            Transaction.DisplayTransactions(UserTransactions);
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid choice.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }    
        }
        private static void AddProductToInventory()
        {
            try
            {
                Console.WriteLine("Enter product details:");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: $ ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantity: ");
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Select product type:");
                Console.WriteLine("1. Electronics");
                Console.WriteLine("2. Clothes");
                Console.WriteLine("3. Groceries");
                Console.Write("Enter product type (1-3): ");
                int productType = int.Parse(Console.ReadLine());

                switch (productType)
                {
                    case 1:
                        Console.Write("Brand: ");
                        string brand = Console.ReadLine();
                        Electronics electronicProduct = new Electronics(productName, price, quantity, brand);
                        storeInventoryObj.AddProduct(electronicProduct);
                        Console.WriteLine($"{productName} is added to inventory.");
                        break;

                    case 2:
                        Console.Write("Size: ");
                        string size = Console.ReadLine();
                        Clothes clothingItem = new Clothes(productName, price, quantity, size);
                        storeInventoryObj.AddProduct(clothingItem);
                        Console.WriteLine($"{productName} is added to inventory.");
                        break;

                    case 3:
                        Console.Write("Expiration date (MM/DD/YYYY): ");
                        DateTime expirationDate = DateTime.Parse(Console.ReadLine());
                        Groceries groceryItem = new Groceries(productName, price, quantity, expirationDate);
                        storeInventoryObj.AddProduct(groceryItem);
                        Console.WriteLine($"{productName} is added to inventory.");
                        break;

                    default:
                        Console.WriteLine("Invalid product type. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void ProcessTransaction()
        {
            try
            {
                Console.WriteLine("Select product for transaction:");

                Console.Write("Enter product name: ");
                string productName = Console.ReadLine();

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product selectedProduct = storeInventoryObj.FindProduct(productName);

                if (selectedProduct != null)
                {
                    Transaction transaction = new Transaction(selectedProduct, quantity);
                    transaction.ProcessTransaction();
                }
                else
                {
                    throw new Exception($"Product '{productName}' not found in inventory.");
                }

                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid quantity.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
