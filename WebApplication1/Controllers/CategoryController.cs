using Microsoft.AspNetCore.Mvc;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Appsrc.Service;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryService categoryService = new CategoryService();

		public IActionResult Index()
        { 
            if (OnlineUser.Onlineuser is null)
            {
                return RedirectToAction("Error");
            }
            return View(categoryService.GetAllCategories());
        }

        public IActionResult Create()
        {
            Category category = new Category();
            return View(category);
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
           categoryService.AddCategory(category.Name);
            return RedirectToAction("Index");
        }
    }
}
