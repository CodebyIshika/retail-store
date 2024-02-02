using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    public class Inventory
    {
        private List<Product> products;

        // Constructor
        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory:");
            foreach (Product item in products)
            {
                Console.WriteLine($"{item.ProductName} - Price per item: ${item.PriceOfProduct:F}, Quantity: {item.QuantityOfProduct}");
            }
            Console.WriteLine("");
        }

        public Product FindProduct(string productName)
        {
            return products.Find(product => product.ProductName.ToLower() == productName.ToLower());
        }

    }
}
