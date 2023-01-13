using Microsoft.AspNetCore.Mvc;
using MVCApp.Models.Form;

namespace MVCApp.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FormSubmit(FormModel form)
        {
            return View("Index");
        }
    }
}
