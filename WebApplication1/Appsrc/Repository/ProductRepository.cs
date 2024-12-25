using Microsoft.EntityFrameworkCore;
using WebApplication1.Appsrc.Contract;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.Repository
{
    public class ProductRepository : IProductRepository
    {
        private WebApp1DbContext WebApp1DbContext = new WebApp1DbContext();
        public List<Product> GetAll()
        {
            return WebApp1DbContext.products.Include(p => p.Category).Include(p => p.User).ToList();
        }
    }
}
