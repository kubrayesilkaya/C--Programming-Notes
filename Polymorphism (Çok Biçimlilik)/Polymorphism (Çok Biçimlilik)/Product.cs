using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Çok_Biçimlilik_
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product() 
        {
            // boş constructor
        }

        public Product (       // dolu constructor
            int productId,
            string productCode,
            string productName,
            double price)
        {
            this.ProductID = productId;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.Price = price;
        }
        
        public double SetKdv()
        {
            return this.Price * 1.18;
        }
    }
}
