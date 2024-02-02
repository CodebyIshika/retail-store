using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    // Electronics class represents electronic products and inherits from the Product class
    public class Electronics : Product
    {
        private string brand;

        // Constructor for Electronics class
        public Electronics(string productName, double price, double quantity, string brand)
            : base(productName, price, quantity)
        {
            this.brand = brand;
        }

        // Override the Discount method for electronic items
        public override double Discount(double actualPrice)
        {
            return actualPrice * 0.2; // 20% discount for electronic items
        }  
    }

    // Clothes class represents clothing items and inherits from the Product class
    public class Clothes : Product
    {
        private string size;

        // Constructor for Clothes class
        public Clothes(string productName, double price,double quantity, string size)
            : base(productName, price, quantity)
        {
            this.size = size;
        }

        // Override the Discount method for clothes
        public override double Discount(double actualPrice)
        {
            return actualPrice * 0.4; // 40% discount for clothes
        }       
    }

    // Groceries class represents grocery items and inherits from the Product class
    public class Groceries : Product
    {
        private DateTime expirationDate;

        // Constructor for Groceries class
        public Groceries(string productName, double price, double quantity, DateTime expirationDate)
            : base(productName, price, quantity)
        {
            this.expirationDate = expirationDate;
        }

        // Override the Discount method for groceries
        public override double Discount(double actualPrice)
        {
            return actualPrice; // no discount for grocery items
        }     
    }
}
