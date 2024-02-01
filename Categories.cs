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
        public Electronics(string productName, double price, string brand)
            : base(productName, price)
        {
            this.brand = brand;
        }

        public override double Discount(double actualPrice)
        {
            
        }

        public override void ProcessingTransaction(int quantity)
        {
            
        }
    }

    public class Clothes : Product
    {
        private string size;

        public Clothes(string productName, double price, string size)
            : base(productName, price)
        {
            this.size = size;
        }

        public override double Discount(double actualPrice)
        {
            
        }

        public override void ProcessingTransaction(int quantity)
        {

        }
    }

    public class Groceries : Product
    {
        private DateTime expirationDate;

        public Groceries(string productName, double price, DateTime expirationDate)
            : base(productName, price)
        {
            this.expirationDate = expirationDate;
        }

        public override double Discount(double actualPrice)
        {

        }

        public override void ProcessingTransaction(int quantity)
        {
           
        }
    }
}
