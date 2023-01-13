using Microsoft.AspNetCore.Mvc;
using MVCApp.Models.Home;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action2(string parameter123)
        {
            var model = new HomeModel
            {
                LabelA = "aaaaaaaaaaaaaaaaaaaaaaa",
                LabelB = parameter123
            };

            return View("Index", model);
        }
    }
}
