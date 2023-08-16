using System;
using Entities;

namespace Business
{
	public interface IProductService
	{
        public List<Product> GetAll();

        public Product GetById(int id);

        public void Add(Product product);

        public void Delete(Product product);

        public void Update(Product product);

    }
}

