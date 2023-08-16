using System;
using Entities;
using DataAccess.Interfaces;

namespace Business
{
    public class ProductManager: IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}



		public List<Product> GetAll()
		{
			return _productDal.GetAll();
		}

        public void Add(Product product)
        {
			_productDal.Add(product);
        }

        public Product GetById(int id)
        {
            return _productDal.GetByID(id);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

