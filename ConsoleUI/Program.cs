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


            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName);
            }


            try
            {
                productManager.Add(new Product(12, "Laptop", "dört ayaklı masa", 345, 12));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


