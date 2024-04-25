using Readify.Core.Enumerations;
using Readify.Core.Models.Book;
using Readify.Core.Models.Home;

namespace Readify.Core.Contracts
{
	public interface IBookService
	{
		Task<IEnumerable<AllCategoriesQueryModel>> AllCategoriesAsync();

		Task<IEnumerable<BookIndexServiceModel>> LastThreeBooks();

		Task<int> CreateAsync(BookFormModel model, int authorId);

		Task<BookQueryServiceModel> AllAsync(
			string? category = null,
			string? searchTerm = null,
			BookEnumerations sorting = BookEnumerations.Newest,
			int currentPage = 1,
			int booksPerPage = 1);

		Task<IEnumerable<string>> AllCategoriesNamesAsync();
	}
}
