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
        }
    }
}
