using System;

namespace Entities
{

    public class Product: IEntity
    {

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }


        public Product(int productId, string productName, string quantityPerUnit, decimal unitPrice, int unitsInStock)
        {
            ProductID = productId;
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }

    }

}