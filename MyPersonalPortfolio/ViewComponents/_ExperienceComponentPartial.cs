using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values= context.Experiences.ToList();
            return View(values);
        }
    }
}
