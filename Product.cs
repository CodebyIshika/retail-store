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

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double PriceOfProduct
        {
            get { return priceOfProduct; }
            set { priceOfProduct = value; }
        }

        protected Product(string productName, double price)
        {
            this.productName = productName;
            this.priceOfProduct = price;
        }

        public abstract void ProcessingTransaction(int quantity);

        public abstract double Discount(double actualPrice);
    }
}
