using Microsoft.AspNetCore.Mvc;

namespace MyPersonalPortfolio.ViewComponents.LayoutViewComponent
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
