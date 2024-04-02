using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Readify.Infrastructure.Constants.DataConstants;

namespace Readify.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AuthorNameMaxLength)]
        [Comment("Name of Author")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of all the books of author")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
