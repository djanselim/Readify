using Microsoft.EntityFrameworkCore;
using Readify.Core.Contracts;
using Readify.Core.Enumerations;
using Readify.Core.Models.Book;
using Readify.Core.Models.Home;
using Readify.Infrastructure.Data.Common;
using Readify.Infrastructure.Data.Models;

namespace Readify.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository repository;

        public BookService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<BookQueryServiceModel> AllAsync(string? category = null, string? searchTerm = null, BookEnumerations sorting = BookEnumerations.Newest, int currentPage = 1, int booksPerPage = 1)
        {
            var booksQuery = repository.AllReadOnly<Book>();

            if(category != null)
            {
                booksQuery = booksQuery.
                    Where(b => b.Category.Name == category);
            }

            if(searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();

                booksQuery = booksQuery
                    .Where(b => b.Title.Contains(searchTerm) || b.Description.Contains(searchTerm));
            }

            booksQuery = sorting switch
            {
                BookEnumerations.Price => booksQuery
                    .OrderBy(b => b.Price),
                BookEnumerations.Newest => booksQuery
                .OrderByDescending(b => b.Id),
            };

            var books = await booksQuery
                .Skip((currentPage - 1) * booksPerPage)
                .Take(booksPerPage)
                .Select(b => new BookServiceModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price,
                    Category = b.Category.Name
                }).ToListAsync();

            int totalBooks = await booksQuery.CountAsync();

            return new BookQueryServiceModel
            {
                Books = books,
                TotalBooks = totalBooks,
            };
        }

        public async Task<IEnumerable<AllCategoriesQueryModel>> AllCategoriesAsync()
        {
            return await repository
                .AllReadOnly<Category>()
                .Select(c => new AllCategoriesQueryModel
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository
                .AllReadOnly<Category>()
                .Select(c => c.Name)
                .ToListAsync();
        }

        public Task<int> CreateAsync(BookFormModel model, int authorId)
        {
            Book book = new Book
            {
                Title = model.Title,
                Price = model.Price,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
                AuthorId = authorId
            };

            repository.AddAsync(book);
            repository.SaveChangesAsync();

            return Task.FromResult(book.Id);
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
