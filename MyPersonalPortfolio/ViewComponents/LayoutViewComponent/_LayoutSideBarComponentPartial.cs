using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponent
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{ 
			return View(); 
		}
	}
}
