using System;
using Entities;

namespace Business
{
	public interface IProductService
	{
        public List<Product> GetAll();

        public void Add(Product product);
    }
}

