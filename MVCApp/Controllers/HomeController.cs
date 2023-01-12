using Microsoft.AspNetCore.Mvc;
using MVCApp.Models.Home;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Text123 = "qqqqqqqqqqqqq"
            };

            return View(model);
        }

        public void Action1()
        {
            var x = "aaaaaaa";

            x = "bbb";
        }

        public void Action2(string parameter123)
        {
            parameter123 = "bbb";
        }
    }
}
