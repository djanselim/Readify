using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Readify.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Readify.Infrastructure.Data.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    public class Author
    {
        [Key]
        [Comment("Author Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.AuthorNameMaxLength)]
        [Comment("Author's Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.AuthorPhoneNumberMaxLength)]
        [Comment("Auhtor's Phone Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("List of all the books of author")]
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
