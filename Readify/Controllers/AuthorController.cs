using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readify.Core.Models.Author;

namespace Readify.Controllers
{
	[Authorize]
	public class AuthorController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Become()
		{
			var model = new BecomeAuthorFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Become(BecomeAuthorFormModel model)
		{
			return RedirectToAction(nameof(BookController.Mine), "Books");
		}
	}
}
