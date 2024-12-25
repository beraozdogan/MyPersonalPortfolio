using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponent
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
	public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
