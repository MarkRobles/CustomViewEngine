using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomViewEngine.ViewModels
{
    public class Store
    {

        public Store()
        {
            Products = new List<Models.Product>
            {
                new Models.Product { ID = 1, ProductName = "Azucar", UnitPrice = 10, UnitsInStock = 100 },
                new Models.Product { ID = 2, ProductName = "Leche", UnitPrice = 13, UnitsInStock = 200 },
                new Models.Product { ID = 3, ProductName = "Huevos", UnitPrice = 20, UnitsInStock = 10 },
                new Models.Product { ID = 4, ProductName = "Arroz", UnitPrice = 30, UnitsInStock = 90 },
                new Models.Product { ID = 5, ProductName = "Frijol", UnitPrice = 80, UnitsInStock = 15 }


            };
        }
        public List<Models.Product> Products { get; set; }
        public IEnumerable IDs
        {
            get
            {
                return Products.Select(p => new { p.ID, p.ProductName }).ToArray();
            }

        }
    }
}