using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readify.Core.Contracts;
using Readify.Models;
using System.Diagnostics;

namespace Readify.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;	
		private readonly IBookService bookService;

		public HomeController(ILogger<HomeController> logger, IBookService _bookService)
		{
			_logger = logger;
			bookService = _bookService;
		}



		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			var model = await bookService.LastThreeBooks();

			return View(model);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
