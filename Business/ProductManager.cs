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

			// iş kodları yazılır. Eğer herşey yolundaysa return işlemi yapılır. Bu sınıfın varolma nedeni budur.

			return _productDal.GetAll();
		}

        public void Add(Product product)
        {
			if(product.ProductName == "Laptop")
			{
				throw new DuplicateProductException("Hali hazırda var olan laptopu ekleyemezsiniz");
			}

			_productDal.Add(product);
        }
    }
}

