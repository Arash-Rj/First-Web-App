using WebApplication1.Appsrc.Contract;
using WebApplication1.Models;
using WebApplication1.Appsrc.Repository;

namespace WebApplication1.Appsrc.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository ProductRepository = new ProductRepository();
        public List<Product> GetAllProducts()
        {
            if (ProductRepository.GetAll() == null)
            {
                throw new NullReferenceException("NO Products Found.");
            }
            return ProductRepository.GetAll();
        }
    }
}
