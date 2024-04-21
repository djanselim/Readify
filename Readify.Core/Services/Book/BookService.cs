using Microsoft.EntityFrameworkCore;
using Readify.Core.Contracts;
using Readify.Core.Models.Home;
using Readify.Infrastructure.Data.Common;

namespace Readify.Core.Services.Book
{
	public class BookService : IBookService
	{
		private readonly IRepository repository;

		public BookService(IRepository _repository)
		{
			repository = _repository;
		}

		public async Task<IEnumerable<BookIndexServiceModel>> LastThreeBooks()
		{
			return await repository
				.AllReadOnly<Infrastructure.Data.Models.Book>()
				.OrderByDescending(b => b.Id)
				.Take(3)
				.Select(b => new BookIndexServiceModel
				{
					Id = b.Id,
					Title = b.Title,
					ImageUrl = b.ImageUrl
				}).ToListAsync();
		}
	}
}
