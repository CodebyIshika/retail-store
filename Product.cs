using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    public abstract class Product
    {
        private string productName;
        protected double priceOfProduct;

        public string ProductName { get; set; }
        public int PriceOfProduct { get; set; }

        protected Product(string productName, double price)
        {
            this.productName = productName;
            this.priceOfProduct = price;
        }

        public abstract void ProcessingTransaction(int quantity);

        public abstract double Discount(double actualPrice);
    }
}
