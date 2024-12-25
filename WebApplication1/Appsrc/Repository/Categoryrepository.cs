using WebApplication1.Appsrc.Contract;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.Repository
{
    public class Categoryrepository : ICategoryRepository
    {
        private WebApp1DbContext WebApp1DbContext = new WebApp1DbContext();

        public void Creat(string name)
        {
            Category newCategory = new Category(name);
            WebApp1DbContext.Add(newCategory);
            WebApp1DbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return WebApp1DbContext.categories.ToList();
        }
    }
}

