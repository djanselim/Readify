using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Readify.Core.Contracts;
using Readify.Core.Models.Author;
using Readify.Extensions;
using static Readify.Core.Constants.MessageConstants;

namespace Readify.Controllers
{
	public class AuthorController : BaseController
	{
		private readonly IAuthorService authorService;

        public AuthorController(IAuthorService _authorService)
        {
			authorService = _authorService;		  
        }

        [HttpGet]
		public async Task<IActionResult> Become()
		{
            if (await authorService.IsAnAuthor(User.Id()))
            {
				return RedirectToAction(nameof(BookController.Publish), "Book");
            }

            var model = new BecomeAuthorFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Become(BecomeAuthorFormModel model)
		{
			if(await authorService.AuthorWithPhoneNumberExistsAsync(model.PhoneNumber))
			{
				ModelState.AddModelError(nameof(model.PhoneNumber), AlreadyAuthorMessage);
            }

			if (!ModelState.IsValid)
			{
                return View(model);
            }

			await authorService.CreateAsync(User.Id(), model.FullName ,model.PhoneNumber);

			return RedirectToAction(nameof(BookController.Mine), "Book");
		}
	}
}
