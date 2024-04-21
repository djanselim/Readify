using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readify.Core.Models.Book;

namespace Readify.Controllers
{
	[Authorize]
	public class BookController : Controller
	{
		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> AllCategories()
		{
			var model = new AllCategoriesQueryModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Mine()
		{
			var model = new AllBooksQueryModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var model = new BookDetailsViewModel();

			return View(model);
		}

		[HttpGet]
		public IActionResult Publish()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Publish(BookFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = 1 });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = new BookFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, BookFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = 1 });
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			var model = new BookDetailsViewModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(BookDetailsViewModel model)
		{
			return RedirectToAction(nameof(Mine));
		}

		[HttpPost]
		public async Task<IActionResult> Buy(int id)
		{
			return RedirectToAction(nameof(Details), new { id = 1 });
		}
	}
}
