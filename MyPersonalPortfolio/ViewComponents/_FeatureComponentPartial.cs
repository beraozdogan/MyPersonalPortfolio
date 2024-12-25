using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
