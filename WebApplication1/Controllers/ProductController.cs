using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Appsrc.DataBase;
using WebApplication1.Appsrc.Service;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private ProductService ProductService = new ProductService();
        public IActionResult Index()
        {
            if (OnlineUser.Onlineuser is null)
            {
                return RedirectToAction("Error");
            }
            return View(ProductService.GetAllProducts());
        }

    }
}
