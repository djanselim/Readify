using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Readify.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Name of Author")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of all the books of author")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
