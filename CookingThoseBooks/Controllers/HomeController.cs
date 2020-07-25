using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingThoseBooks.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CookingThoseBooks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            HomeModel model = new HomeModel();
            model.AddingNumbers();

            return View(model);
        }
    }
}