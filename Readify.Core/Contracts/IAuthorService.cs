namespace Readify.Core.Contracts
{
    public interface IAuthorService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> AuthorWithPhoneNumberExistsAsync(string phoneNumber);

        Task CreateAsync(string userId, string fullName ,string phoneNumber); 

        Task<bool> IsAnAuthor(string userId);

        Task<int?> GetAuthorIdAsync(string userId);
    }
}
