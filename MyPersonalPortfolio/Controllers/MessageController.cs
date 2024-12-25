using Microsoft.AspNetCore.Mvc;
using MyPersonalPortfolio.DAL.Context;

namespace MyPersonalPortfolio.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context= new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values=context.Messages.ToList();
			return View(values);
		}
		public IActionResult DeleteMessage(int id)
		{
			var value=context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public ActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
			return View(value);
			
		}
	}
}
