﻿using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}