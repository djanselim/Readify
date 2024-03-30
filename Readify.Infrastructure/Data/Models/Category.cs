using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Readify.Infrastructure.Data.Models
{
    public class Category
    {
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of books with current category")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
