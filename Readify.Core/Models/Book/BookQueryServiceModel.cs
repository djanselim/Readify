namespace Readify.Core.Models.Book
{
    public class BookQueryServiceModel
    {
        public int TotalBooks { get; set; }

        public IEnumerable<BookServiceModel> Books { get; set; } = new List<BookServiceModel>();
    }
}
