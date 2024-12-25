using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
