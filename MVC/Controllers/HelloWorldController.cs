using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVC.Controllers
{
	public class HelloWorldController : Controller
	{
		public IActionResult Index(string name)
		{
			ViewData["Name"] = name;
			return View();
		}

		public string Welcome(string name)
		{
			return HtmlEncoder.Default.Encode($"We, comment ça va, {name} ?");
		}
	}
}