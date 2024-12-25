using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface ICategoryService
    {
        public List<Category> GetAllCategories();
        public void AddCategory(string name);
    }
}
