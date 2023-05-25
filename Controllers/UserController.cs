using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "Heyder";
            ViewData["Surname"] = "Alizade";
            ViewBag.Age = 19;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "0503903819";
            //return RedirectToAction("Test");
            return View();
        }
    }
}