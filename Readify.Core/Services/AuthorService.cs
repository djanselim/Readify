using Microsoft.EntityFrameworkCore;
using Readify.Core.Contracts;
using Readify.Infrastructure.Data.Common;
using Readify.Infrastructure.Data.Models;

namespace Readify.Core.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository repository;

        public AuthorService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> AuthorWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository
                .AllReadOnly<Author>()
                .AnyAsync(a => a.PhoneNumber == phoneNumber);
        }

        public async Task CreateAsync(string userId, string fullName, string phoneNumber)
        {
            await repository.AddAsync(new Author
            {
                UserId = userId,
                FullName = fullName,
                PhoneNumber = phoneNumber
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<Author>()
                .AnyAsync(a => a.UserId == userId);
        }

        public async Task<int?> GetAuthorIdAsync(string userId)
        {
            return (await repository
                .AllReadOnly<Author>()
                .FirstOrDefaultAsync(a => a.UserId == userId))?.Id;
        }

        public async Task<bool> IsAnAuthor(string userId)
        {
            return await repository
                .AllReadOnly<Author>()
                .AnyAsync(a => a.UserId == userId);
        }
    }
}
