using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Readify.Infrastructure.Constants.DataConstants;

namespace Readify.Infrastructure.Data.Models
{
    public class Category
    {
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of books with current category")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
