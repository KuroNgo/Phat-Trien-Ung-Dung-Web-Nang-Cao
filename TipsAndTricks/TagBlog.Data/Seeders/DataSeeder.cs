using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Data.Contexts;
using TagBlog.Core.Entities;
namespace TagBlog.Data.Seeders
{
    public class DataSeeder : IDataSeeder
    {
        public readonly BlogDbContext _dbContext;

        public DataSeeder(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Initialize()
        {
            //tại vì có dữ liệu rồi nên nó sẽ ko thêm nữa
            _dbContext.Database.EnsureCreated();
            if (_dbContext.Posts.Any())  return; 
            var authors = AddAuthor();
            var categories=AddCategory();
            var tags=AddTag();
            var posts=AddPost(authors, categories, tags);
        }

        private IList<Author> AddAuthor()
        {
            var authors = new List<Author>()
            {
                new()
                {
                    FullName = "Jason Mouth",
                    UrlSlug = "Jason-mouth",
                    Email="json@gmail.com",
                    JoinedDate=new DateTime(2022,10,21)

                },
                new()
                {
                    FullName = "Jessica Wonder",
                    UrlSlug = "Jessica Wonder",
                    Email="jessica665@motip.com",
                    JoinedDate=new DateTime(2020,4,19)
                },
                new()
                {
                    FullName = "Kathy Smith",
                    UrlSlug = "kathy Smith",
                    Email="kathy.smith@iworld.com",
                    JoinedDate=new DateTime(2016,9,6)
                }
            };
            _dbContext.Authors.AddRange(authors);
            _dbContext.SaveChanges();

            return authors;
        }
        private IList<Category> AddCategory()
        {
            var categories = new List<Category>()
            {
                new() { Name = ".NET Core", Description = ".NET Core", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Architecture", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Messaging", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "OOP", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Design Pattern", Description = "Design Pattern", UrlSlug = "", ShowOnMenu = true },
                new() { Name = ".NET Core", Description = ".NET Core", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Architecture", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Messaging", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "OOP", Description = "Architecture", UrlSlug = "", ShowOnMenu = true },
                new() { Name = "Design Pattern", Description = "Design Pattern", UrlSlug = "", ShowOnMenu = true }
            };

            _dbContext.Categories.AddRange(categories);
            _dbContext.SaveChanges();

            return categories;
        }

        private IList<Tag> AddTag()
        {
            var tags = new List<Tag>()
            {
                new() {Name="Google",Description="Google applications",UrlSlug=""},
                new(){Name="ASP.net MVC",Description="ASP.NET MVC",UrlSlug=""},
                new(){Name="Razor",Description="Razor",UrlSlug=""},
                new(){Name="Blazor",Description="Blazor",UrlSlug=""},
                new(){Name="Deep Learning",Description="Deep Learning",UrlSlug=""},
                new() {Name="Natural Network",Description="Natural Network",UrlSlug=""},
                new(){Name="ASP.net MVC",Description="ASP.NET MVC",UrlSlug=""},
                new(){Name="Razor",Description="Razor",UrlSlug=""},
                new(){Name="Blazor",Description="Blazor",UrlSlug=""},
                new(){Name="Deep Learning",Description="Deep Learning",UrlSlug=""},
                new() {Name="Natural Network",Description="Natural Network",UrlSlug=""}
            };

            _dbContext.Tags.AddRange(tags);
            _dbContext.SaveChanges();

            return tags;
        }
        private IList<Post> AddPost(IList<Author> authors,IList<Category> categories,IList<Tag> tags)
        {


            var posts = new List<Post>()
            {
                new()
                {
                    Title="ASP.NET COre Diagnostic Scenarious",
                    ShortDescription="David and Friend has a greate reposive",
                    Description="Here's a few greate DON'T and Do examples",
                    Meta="David and friends has a greate repository filled",
                    UrlSlug="ASPNET core diagnoretic-scenarious",
                    Published=true,
                    PostDate=new DateTime(2021,9,30,10,20,0),
                    ModifedDate=null,
                    ViewCount=10,
                    Author=authors[0],
                    Category=categories[0],
                    Tags=new List<Tag>()
                    {
                        tags[0]
                    }
                },
                new()
                {
                    Title="ASP.NET COre Diagnostic Scenarious",
                    ShortDescription="David and Friend has a greate reposive",
                    Description="Here's a few greate DON'T and Do examples",
                    Meta="David and friends has a greate repository filled",
                    UrlSlug="ASPNET core diagnoretic-scenarious",
                    Published=true,
                    PostDate=new DateTime(2021,9,30,10,20,0),
                    ModifedDate=null,
                    ViewCount=10,
                    Author=authors[0],
                    Category=categories[0],
                    Tags=new List<Tag>()
                    {
                        tags[1]
                    }
                },
                new()
                {
                    Title="ASP.NET COre Diagnostic Scenarious",
                    ShortDescription="David and Friend has a greate reposive",
                    Description="Here's a few greate DON'T and Do examples",
                    Meta="David and friends has a greate repository filled",
                    UrlSlug="ASPNET core diagnoretic-scenarious",
                    Published=true,
                    PostDate=new DateTime(2021,9,30,10,20,0),
                    ModifedDate=null,
                    ViewCount=10,
                    Author=authors[0],
                    Category=categories[0],
                    Tags=new List<Tag>()
                    {
                        tags[0]
                    }
                },
                new()
                {
                    Title="ASP.NET COre Diagnostic Scenarious",
                    ShortDescription="David and Friend has a greate reposive",
                    Description="Here's a few greate DON'T and Do examples",
                    Meta="David and friends has a greate repository filled",
                    UrlSlug="ASPNET core diagnoretic-scenarious",
                    Published=true,
                    PostDate=new DateTime(2021,9,30,10,20,0),
                    ModifedDate=null,
                    ViewCount=10,
                    Author=authors[0],
                    Category=categories[0],
                    Tags=new List<Tag>()
                    {
                        tags[2]
                    }
                },
                new()
                {
                    Title="ASP.NET COre Diagnostic Scenarious",
                    ShortDescription="David and Friend has a greate reposive",
                    Description="Here's a few greate DON'T and Do examples",
                    Meta="David and friends has a greate repository filled",
                    UrlSlug="ASPNET core diagnoretic-scenarious",
                    Published=true,
                    PostDate=new DateTime(2021,9,30,10,20,0),
                    ModifedDate=null,
                    ViewCount=10,
                    Author=authors[0],
                    Category=categories[0],
                    Tags=new List<Tag>()
                    {
                        tags[3]
                    }
                }
            };
            
            _dbContext.Posts.AddRange(posts);
            _dbContext.SaveChanges();

            return posts;
            
        }
    }
}
