using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    /// <summary>
    /// Represents the inventory of products in the retail store.
    /// </summary>
    public class Inventory
    {
        // Field
        private List<Product> products;

        // Constructor
        public Inventory()
        {
            // Initialize the list of products in the inventory.
            products = new List<Product>();
        }

        /// <summary>
        /// Adds a new product to the inventory.
        /// </summary>
        public void AddProduct(Product product)
        {
            Product existingProduct = FindProduct(product.ProductName);

            if (existingProduct != null)
            {
                // Product already exists, update the quantity
                existingProduct.QuantityOfProduct += product.QuantityOfProduct;
            }
            else
            {
                // Product does not exist, add it to the inventory
                products.Add(product);
            }
        }

        /// <summary>
        /// Displays the current inventory, including product names, prices, and quantities.
        /// </summary>
        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory:");
            foreach (Product item in products)
            {
                Console.WriteLine($"{item.ProductName} - Price per item: ${item.PriceOfProduct:F}, Quantity: {item.QuantityOfProduct}");
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Finds a product in the inventory based on its name 
        /// </summary>
        public Product FindProduct(string productName)
        {
            // Convert both strings to lowercase 
            string inputLower = productName.ToLower();

            foreach (Product product in products)
            {
                // Compare product names
                if (product.ProductName.ToLower() == inputLower)
                {
                    // If name matches
                    return product;
                }
            }
            return null;
        }
    }
}
