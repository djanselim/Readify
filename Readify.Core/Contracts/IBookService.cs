using Readify.Core.Models.Home;

namespace Readify.Core.Contracts
{
	public interface IBookService
	{
		Task<IEnumerable<BookIndexServiceModel>> LastThreeBooks();
	}
}
