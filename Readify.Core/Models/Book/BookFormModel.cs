using Readify.Core.Constants;
using Readify.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using static Readify.Core.Constants.MessageConstants;

namespace Readify.Core.Models.Book
{
    public class BookFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(DataConstants.BookTitleMaxLength,
                        MinimumLength = DataConstants.BookTitleMinLength,
                        ErrorMessage = InvalidBookTitleMessage)]
        [Display(Name = "Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = MessageConstants.RequiredMessage)]
        [StringLength(DataConstants.AuthorNameMaxLength,
                         MinimumLength = DataConstants.AuthorNameMinLength,
                         ErrorMessage = RequiredMessage)]
        public string AuthorName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(DataConstants.BookDescriptionMaxLength,
                        MinimumLength = DataConstants.BookDescriptionMinLength,
                        ErrorMessage = InvalidBookDescriptionMessage)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        [StringLength(DataConstants.BookLanguageMaxLength, MinimumLength = DataConstants.BookLanguageMinLength,
            ErrorMessage = InvalidLanguageMessage)]
        [Required(ErrorMessage = RequiredMessage)]
        public string Language { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string ImageUrl { get; set; } = string.Empty;


        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<AllCategoriesQueryModel> Categories { get; set; } = new List<AllCategoriesQueryModel>();
    }
}
