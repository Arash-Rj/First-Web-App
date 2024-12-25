using WebApplication1.Models;

namespace WebApplication1.Appsrc.Contract
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
        public void Creat(string name);
    }
}
