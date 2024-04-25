using Readify.Core.Enumerations;
using Readify.Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Readify.Core.Models.Book
{
	public class AllBooksQueryModel
	{
		public int BookPerPage { get; } = 3;

		public string Category { get; init; } = string.Empty;

		[Display(Name = "Search with text")]
		public string SearchTerm { get; init; } = string.Empty;

		public BookEnumerations SortBy { get; init; } 

		public int CurrentPage { get; init; } = 1;

		public int TotalBooks { get; set; }

		public IEnumerable<string> Categories { get; set; } = null!;

		public IEnumerable<BookServiceModel> Books { get; set; } = null!;
	}
}
