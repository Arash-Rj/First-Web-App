using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
    }
}
