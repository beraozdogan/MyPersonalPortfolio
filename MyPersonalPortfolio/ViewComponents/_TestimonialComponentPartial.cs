using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
