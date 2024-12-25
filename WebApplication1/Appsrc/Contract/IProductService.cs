using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface IProductService
    {
        public List<Product> GetAllProducts();
        
    }
}
