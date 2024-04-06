using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readify.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.Infrastructure.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category[]
            {
                new Category { Id = 1, Name = "Fiction" },
                new Category { Id = 2, Name = "Non-Fiction" },
                new Category { Id = 3, Name = "Mystery & Thriller" },
                new Category { Id = 4, Name = "Science Fiction & Fantasy" },
                new Category { Id = 5, Name = "Romance" },
                new Category { Id = 6, Name = "Historical Fiction" },
                new Category { Id = 7, Name = "Biography & Memoir" },
                new Category { Id = 8, Name = "Self-Help & Personal Development" },
                new Category { Id = 9, Name = "Business & Economics" },
                new Category { Id = 10, Name = "History" },
                new Category { Id = 11, Name = "Travel" },
                new Category { Id = 12, Name = "Billing" },
                new Category { Id = 13, Name = "Art & Photography" },
                new Category { Id = 14, Name = "Science & Nature" },
                new Category { Id = 15, Name = "Religion & Spirituality" },
                new Category { Id = 16, Name = "Health & Fitness" },
                new Category { Id = 17, Name = "Children's Books" },
                new Category { Id = 18, Name = "Young Adult" },
                new Category { Id = 19, Name = "Graphic Novels & Comics" },
                new Category { Id = 20, Name = "Poetry" }
            });
        }
    }
}
