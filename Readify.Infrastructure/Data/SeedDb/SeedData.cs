using Microsoft.AspNetCore.Identity;
using Readify.Infrastructure.Data.Models;

namespace Readify.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public IdentityUser AuthorUser { get; set; }
        
        public IdentityUser GuestUser { get; set; }
        
        public Author Author { get; set; }
        
        public Category FictionCategory { get; set; }
        
        public Category NonFictionCategory { get; set; }
        
        public Category MysteryThrillerCategory { get; set; }
        
        public Category ScienceFictionFantasyCategory { get; set; }
        
        public Category RomanceCategory { get; set; }
        
        public Category HistoricalFictionCategory { get; set; }
        
        public Category BiographyMemoirCategory { get; set; }
        
        public Category SelfHelpPersonalDevelopmentCategory { get; set; }
        
        public Category BusinessEconomicsCategory { get; set; }
        
        public Category HistoryCategory { get; set; }
        
        public Category TravelCategory { get; set; }   
        
        public Category BillingCategory { get; set; }
        
        public Category ArtPhotographyCategory { get; set; }
        
        public Category ScienceNatureCategory { get; set; }
        
        public Category ReligionSpiritualityCategory { get; set; }
        
        public Category HealthFitnessCategory { get; set; }
        
        public Category ChildrensBooksCategory { get; set; }
        
        public Category YoungAdultCategory { get; set; }
        
        public Category GraphicNovelsComicsCategory { get; set; }
        
        public Category PoetryCategory { get; set; }
        
        public Book FirstBook { get; set; }
        
        public Book SecondBook { get; set; }
        
        public Book ThirdBook { get; set;}

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AuthorUser = new IdentityUser
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "author",
                NormalizedUserName = "AUTHOR",
                Email = "author@mail.com",
                NormalizedEmail = "author@mail.com",
            };

            AuthorUser.PasswordHash = hasher.HashPassword(AuthorUser, "author");

            GuestUser = new IdentityUser
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest",
                NormalizedUserName = "GUEST",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest");
        }

        public SeedData()
        {
            SeedUsers();
            SeedAuthors();
            SeedCategories();
            SeedBooks();
        }

        private void SeedAuthors()
        {
            Author = new Author
            {
                Id = 1,
                UserId = AuthorUser.Id
            };
        }   

        private void SeedCategories()
        {
            FictionCategory = new Category
            {
                Id = 1,
                Name = "Fiction"
            };

            NonFictionCategory = new Category
            {
                Id = 2,
                Name = "Non-fiction"
            };

            MysteryThrillerCategory = new Category
            {
                Id = 3,
                Name = "Mystery/Thriller"
            };

            ScienceFictionFantasyCategory = new Category
            {
                Id = 4,
                Name = "Science Fiction/Fantasy"
            };

            RomanceCategory = new Category
            {
                Id = 5,
                Name = "Romance"
            };

            HistoricalFictionCategory = new Category
            {
                Id = 6,
                Name = "Historical Fiction"
            };

            BiographyMemoirCategory = new Category
            {
                Id = 7,
                Name = "Biography/Memoir"
            };

            SelfHelpPersonalDevelopmentCategory = new Category
            {
                Id = 8,
                Name = "Self-Help/Personal Development"
            };

            BusinessEconomicsCategory = new Category
            {
                Id = 9,
                Name = "Business/Economics"
            };

            HistoryCategory = new Category
            {
                Id = 10,
                Name = "History"
            };

            TravelCategory = new Category
            {
                Id = 11,
                Name = "Travel"
            };

            BillingCategory = new Category
            {
                Id = 12,
                Name = "Cookbooks/Food"
            };

            ArtPhotographyCategory = new Category
            {
                Id = 13,
                Name = "Art/Photography"
            };  

            ScienceNatureCategory = new Category
            {
                Id = 14,
                Name = "Science/Nature"
            };

            ReligionSpiritualityCategory = new Category
            {
                Id = 15,
                Name = "Religion/Spirituality"
            };

            HealthFitnessCategory = new Category
            {
                Id = 16,
                Name = "Health/Fitness"
            };

            ChildrensBooksCategory = new Category
            {
                Id = 17,
                Name = "Children's Books"
            };

            YoungAdultCategory = new Category
            {
                Id = 18,
                Name = "Young Adult"
            };

            GraphicNovelsComicsCategory = new Category
            {
                Id = 19,
                Name = "Graphic Novels/Comics"
            };

            PoetryCategory = new Category
            {
                Id = 20,
                Name = "Poetry"
            };
        }


        private void SeedBooks()
        {
            FirstBook = new Book
            {
                Id = 1,
                Title = "The Great Gatsby",
                AuthorId = Author.Id,
                CategoryId = FictionCategory.Id,
                Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7a/The_Great_Gatsby_Cover_1925_Retouched.jpg",
                Rating = 4.5m
            };

            SecondBook = new Book
            {
                Id = 2,
                Title = "To Kill a Mockingbird",
                AuthorId = Author.Id,
                CategoryId = FictionCategory.Id,
                Description = "To Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools.",
                ImageUrl = "https://m.media-amazon.com/images/I/71FxgtFKcQL._AC_UF1000,1000_QL80_.jpg",
                Rating = 4.8m
            };

            ThirdBook = new Book
            {
                Id = 3,
                Title = "1984",
                AuthorId = Author.Id,
                CategoryId = FictionCategory.Id,
                Description = "Nineteen Eighty-Four: A Novel, often referred to as 1984, is a dystopian social science fiction novel by the English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                ImageUrl = "https://m.media-amazon.com/images/I/71rpa1-kyvL._AC_UF1000,1000_QL80_.jpg",
                Rating = 4.9m
            };
        }
    }
}

