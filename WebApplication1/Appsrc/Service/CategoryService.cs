using WebApplication1.Appsrc.Contract;
using WebApplication1.Appsrc.Repository;
using WebApplication1.Models;

namespace WebApplication1.Appsrc.Service
{
    public class CategoryService: ICategoryService
    {
        private ICategoryRepository CategoryRepository = new Categoryrepository();

        public void AddCategory(string name)
        {
            CategoryRepository.Creat(name);
        }
        public List<Category> GetAllCategories()
        {
            if (CategoryRepository.GetAll() == null)
            {
                throw new NullReferenceException("NO Categories Found.");
            }
            return CategoryRepository.GetAll();
        }
    }
}
