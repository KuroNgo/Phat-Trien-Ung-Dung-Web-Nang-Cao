using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Core.Entities;
using TagBlog.Data.Contexts;

namespace TagBlog.Services.Tags
{
    public class TagRespository:ITagRespository
    {
        private readonly BlogDbContext _dbcontext;
        public TagRespository(BlogDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // Tìm một thẻ có tên định danh là slug
        public async Task<Tag> GetTag(string slug, CancellationToken cancellationToken = default)
        {
            IQueryable<Tag> tagQuery = _dbcontext.Set<Tag>()
                .Include(x => x.UrlSlug);
            if (slug != "")
            {
                tagQuery = tagQuery.Where(x => x.UrlSlug == slug);
            }
            return await tagQuery.FirstOrDefaultAsync(cancellationToken);
        }
    }
}
