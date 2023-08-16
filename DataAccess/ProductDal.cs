using DataAccess.Interfaces;
using Entities;


namespace DataAccess
{

    public class ProductDal: IProductDal
    {
        

        public void Add(Product product)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            };

        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Remove(context.Products.SingleOrDefault(p => p.ProductID == product.ProductID));
                context.SaveChanges();
            };
        }

        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            };

        }

        public Product GetByID(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductID == id);
            };
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var productToBeUpdated = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                productToBeUpdated = product;
                context.SaveChanges();
            };
        }
    }

}

