using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readify.Infrastructure.Data.Models;

namespace Readify.Infrastructure.Data.SeedDb
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            var data = new SeedData();

            builder.HasData(new Author[] { data.Author });
        }
    }
}
