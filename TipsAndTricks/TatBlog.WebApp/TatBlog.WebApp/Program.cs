using Microsoft.EntityFrameworkCore;
using TagBlog.Data.Contexts;
using TagBlog.Data.Seeders;
using TagBlog.Services.Blogs;
using TatBlog.WebApp.Extensions;
namespace TatBlog.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            {
                builder.ConfigureMvc()
                       .ConfigureServices();
            }

            var app = builder.Build();
            {
                app.UseRequestPipeline();
                app.UseBlogRoutes();
                app.UseDataSeeder();
            }

            app.Run();
        }
    }
}
