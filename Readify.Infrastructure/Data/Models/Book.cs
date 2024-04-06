using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Readify.Infrastructure.Constants.DataConstants;

namespace Readify.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        [Comment("Book identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(BookTitleMaxLength)]
        [Comment("Title of the book")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Comment("Image URL of the book")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [MaxLength(BookDescriptionMaxLength)]
        [Comment("Description of the book")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Price of the book")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Rating of the book")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public decimal Rating { get; set; } = 2.5m;

        [Required]
        [MaxLength(BookLanguageMaxLength)]
        [Comment("Language of the book")]
        public string Language { get; set; } = string.Empty;

        [Required]
        [Comment("Date of publication")]
        public DateTime DateOfPublication { get; set; }

        [Required]
        [Comment("Author identifier")]
        public int AuthorId { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;
    }
}
