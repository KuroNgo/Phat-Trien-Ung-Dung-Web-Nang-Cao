using TagBlog.Data.Contexts;
using TagBlog.Services.Blogs;

namespace TagBlog.WinApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var context = new BlogDbContext();
            IBlogRepository blogRepository = new BlogRepository(context);
            var pagingParams = new PagingParams
            {
                PageNumber = 1,
                PageSize = 5,
                SortColumn = "name",
                SortOrder = "DESC"
            };
            var tagsList = await blogRepository.GetPagedTagsAsync(pagingParams);

            Console.WriteLine("{0,-5}{1,-50}{2,10}",
                "ID", "Name", "Count");

            foreach (var item in tagsList)
            {
                Console.WriteLine("{0,-5}{1,-50}{2,10}",
                    item.Id, item.Name, item.PostCount);
            }
            // Khi cập nhật thông tin mới thì lúc chạy lên lại không hiển thị những thông tin mới đó mà chỉ nhận những thông tin cũ
            // Tạo đối tượng DbContext để quản lý phiên bản làm việc
            // VỚi CSDL và trạng thái của đối tượng
            //var context = new BlogDbContext();
            //IBlogRepository blogRepository = new BlogRepository(context);
            //var categories=await blogRepository.GetCategoryItemsAsync();
            //Console.WriteLine("{0,-5}{1,-50}{2,10}", "ID", "Name", "Count");
            //foreach(var item in categories)
            //{
            //    Console.WriteLine("{0,-5}{1,-50}{2,10}",item.Id,item.Name,item.PostCount);
            //}
            //var posts = await blogRepository.GetPopularArticleAsync(3);
            //var posts=context.Posts
            //    .Where(p=>p.Published)
            //    .OrderBy(p=>p.Title)
            //    .Select(p=>new
            //    {
            //        Id=p.Id,
            //        Title=p.Title,
            //        ViewCount=p.ViewCount,
            //        PostDate=p.PostDate,
            //        Author=p.Author.FullName,
            //        Category=p.Category.Name

            //    })
            //    .ToList();
            //foreach (var post in posts)
            //{
            //    Console.WriteLine("ID               :{0}", post.Id);
            //    Console.WriteLine("Title            :{0}", post.Title);
            //    Console.WriteLine("View             :{0}", post.ViewCount);
            //    Console.WriteLine("Date             :{0:MM/dd/yyyy}", post.PostDate);
            //    Console.WriteLine("Author           :{0}", post.Author);
            //    Console.WriteLine("Categor          :{0}", post.Category);
            //    Console.WriteLine("".PadRight(80, '-'));

            //}
            // Tạo đối tượng khởi tạo dữ liệu mẫu
            //var seeder = new DataSeeder(context);

            // GỌi hàm Initialize để nhập dữ liệu mẫu
            //seeder.Initialize();

            // Đọc danh sách tác giả từ cơ sở dữ liệu mẫu
            //var authors=context.Authors.ToList();

            //// Xuất danh sách tác giả ra màn hình
            //Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12}",
            //    "ID", "Full Name", "Email", "Joined Date");

            //foreach(var author in authors)
            //{
            //    Console.WriteLine("{0,-4}{1,-30}{2,-30}{3,12:MM/dd/yyyy}",
            //        author.Id, author.FullName, author.Email, author.JoinedDate);
            //}

        }
    }
}