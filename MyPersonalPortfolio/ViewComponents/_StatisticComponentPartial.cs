using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _StatisticComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
