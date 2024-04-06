using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readify.Infrastructure.Data.Models
{
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("List of all the books of author")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
