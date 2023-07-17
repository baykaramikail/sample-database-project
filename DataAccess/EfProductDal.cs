using System;
using Entities;


namespace DataAccess
{

    public class EfProductDal : IProductDal
    {
        List<Product> _products;

        public EfProductDal()
        {
            _products = new List<Product>()
            {
                new Product(1, "asus ef bilgisayar", "16 gb ram", 655, 1),
                new Product(1, "acer ef bilgisayar", "16 gb ram", 1200, 0),
                new Product(1, "dell ef bilgisayar", "16 gb ram", 1500, 7),
                new Product(1, "mac ef bilgisayar", "16 gb ram", 760, 3),
                new Product(1, "monster ef bilgisayar", "16 gb ram", 2000, 2)
            };
        }

        public void Add(Product product)
        {
            Console.WriteLine("EfProductDal ile eklendi");

        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

