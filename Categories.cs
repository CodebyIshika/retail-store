using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopFinalProject
{
    public class Electronics : Product
    {
        private string brand;
        public Electronics(string productName, double price, double quantity, string brand)
            : base(productName, price, quantity)
        {
            this.brand = brand;
        }

        public override double Discount(double actualPrice)
        {
            return actualPrice * 0.8; // 20% discount for electronic items
        }  
    }

    public class Clothes : Product
    {
        private string size;

        public Clothes(string productName, double price,double quantity, string size)
            : base(productName, price, quantity)
        {
            this.size = size;
        }

        public override double Discount(double actualPrice)
        {
            return actualPrice * 0.6; // 60% discount for clothes
        }       
    }

    public class Groceries : Product
    {
        private DateTime expirationDate;

        public Groceries(string productName, double price, double quantity, DateTime expirationDate)
            : base(productName, price, quantity)
        {
            this.expirationDate = expirationDate;
        }

        public override double Discount(double actualPrice)
        {
            return actualPrice; // no discount for grocery items
        }     
    }
}
