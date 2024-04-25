using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readify.Core.Contracts;
using Readify.Core.Models.Book;
using Readify.Core.Services;
using Readify.Extensions;

namespace Readify.Controllers
{
	public class BookController : BaseController
	{
		private readonly IBookService bookService;
		private readonly IAuthorService authorService;

		public BookController(IBookService _bookService, IAuthorService _authorService)
		{
            bookService = _bookService;
			authorService = _authorService;
        }

		[HttpGet]
		public async Task<IActionResult> Mine()
		{
			var model = new AllBooksQueryModel();

			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var model = new BookDetailsViewModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Publish()
		{
            var model = new BookFormModel()
            {
                Categories = await bookService.AllCategoriesAsync()
            };

            return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Publish(BookFormModel model)
		{
			if(!ModelState.IsValid)
			{
                model.Categories = await bookService.AllCategoriesAsync();

                return View(model);
            }

			int? authorId = await authorService.GetAuthorIdAsync(User.Id());
			
			int newBookId = await bookService.CreateAsync(model, authorId ?? 0);

			return RedirectToAction(nameof(Details), new { id = newBookId });
		}

		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> All([FromQuery] AllBooksQueryModel model)
		{
			var books = await bookService.AllAsync(
				model.Category,
				model.SearchTerm,
				model.SortBy,
				model.CurrentPage,
				model.BookPerPage
				);

			model.TotalBooks = books.TotalBooks;
			model.Books = books.Books;
			model.Categories = await bookService.AllCategoriesNamesAsync();

			return View(model);
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
