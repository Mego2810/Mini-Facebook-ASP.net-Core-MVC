using Microsoft.AspNetCore.Mvc;

namespace Min_Facebook.PL.Controllers
{
    public class AccountController : Controller
    {
       
        public IActionResult Login()
        {

            return View();


        }
        public IActionResult SignUp()
        {

            return View();

        }
        public IActionResult Profile()
        {
            return View(nameof(Profile));
        }
    }
}
