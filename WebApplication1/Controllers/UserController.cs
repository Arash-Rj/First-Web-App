using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Appsrc.Service;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();    
        public IActionResult Index()
        {
            return View(userService.GetAllUsers());
        }
        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(string name, string email,string password, int age)
        {

           bool isdone =  userService.Register(name, email, password, age);
            return RedirectToAction("Index");
        }
        public IActionResult Login() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            bool isdone = userService.login(email, password);
            return RedirectToAction("Index", "Home");
        }
  
    }
}
