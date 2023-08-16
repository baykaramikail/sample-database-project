using System;
using Business;
using DataAccess;
using Entities;


namespace ConsoleUI
{

    class Program
    {

        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new ProductDal());

            productManager.Add(new Product
            {
                ProductName = "Test",
                QuantityPerUnit = "faldf",
                UnitPrice = 234,
                UnitsInStock = 45

            });

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }


            
        }
    }
}


