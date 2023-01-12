using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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
