using TagBlog.Core.Constracts;
namespace TagBlog.Core.Entities
{
    public class Category : IEntity
    {
        // Mã chuyên mục
        public int Id { get; set; }

        //Tên chuyên mục, tên chủ đề
        public string Name { get; set; }

        // Tên định danh dùng để tạo URL
        public string UrlSlug { get; set; }

        // Mô tả thêm về chuyên mục 
        public string Description { get; set; }

        // Đsanh dấu chuyên mục được hiển thị trên menu
        public bool ShowOnMenu { get; set; }

        // Danh sách các bài viết thuộc chuyên mục
        public IList<Post> Posts { get; set; }

    }
}
