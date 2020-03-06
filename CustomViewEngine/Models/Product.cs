using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomViewEngine.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }

        public Decimal UnitPrice { get; set; }

        public decimal UnitsInStock { get; set; }
    }
}