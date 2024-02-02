using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    public abstract class Product
    {
        // fields
        private string productName;
        protected double priceOfProduct;
        protected double quantityOfProduct;

        // protected
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

        public double QuantityOfProduct
        {
            get { return quantityOfProduct; }
            set { quantityOfProduct = value; }
        }

        // Constructor for the Product class.
        protected Product(string productName, double price, double quantity)
        {
            this.productName = productName;
            this.priceOfProduct = price;
            this.quantityOfProduct = quantity;
        }

        // Abstract method representing the discount calculation for a product.
        public abstract double Discount(double actualPrice);
    }
}
