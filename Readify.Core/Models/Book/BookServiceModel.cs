using Readify.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using Readify.Core.Constants;
using Readify.Infrastructure.Constants;

namespace Readify.Core.Models.Book
{
    public class BookServiceModel : IBookModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [StringLength(DataConstants.BookTitleMaxLength,
            MinimumLength = DataConstants.BookLanguageMinLength,
            ErrorMessage = MessageConstants.InvalidBookTitleMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [StringLength(DataConstants.AuthorNameMaxLength,
            MinimumLength = DataConstants.AuthorNameMinLength,
            ErrorMessage = MessageConstants.RequiredMessage)]
        public string Author { get; set; } = string.Empty;

        [Display(Name = "Image URL")]
        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Language")]
        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [StringLength(DataConstants.BookLanguageMaxLength,
            MinimumLength = DataConstants.BookLanguageMinLength,
            ErrorMessage = MessageConstants.InvalidLanguageMessage)]
        public string Language { get; set; } = string.Empty;

        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [StringLength(DataConstants.CategoryNameMaxLength, MinimumLength = DataConstants.CategoryNameMinLength, ErrorMessage = MessageConstants.InvalidCategoryMessage)]
        public string Category { get; set; } = string.Empty;
    }
}
