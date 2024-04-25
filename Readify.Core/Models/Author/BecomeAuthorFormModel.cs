using System.ComponentModel.DataAnnotations;
using static Readify.Core.Constants.MessageConstants;
using static Readify.Infrastructure.Constants.DataConstants;

namespace Readify.Core.Models.Author
{
    public class BecomeAuthorFormModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(AuthorNameMaxLength,
			            MinimumLength = AuthorNameMinLength,
			            ErrorMessage = InvalidAuthorNameMessage)]
		public string FullName { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(AuthorPhoneNumberMaxLength,
			MinimumLength = AuthorPhoneNumberMinLength,
			ErrorMessage = InvalidPhoneNumberMessage)]
		[Display(Name = "Phone Number")]
		[Phone]
		public string PhoneNumber { get; set; } = string.Empty;
	}
}
