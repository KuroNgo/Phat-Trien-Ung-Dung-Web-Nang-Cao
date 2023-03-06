using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Core.Entities;

namespace TagBlog.Services.Tags
{
    public interface ITagRespository
    {
        Task<Tag> GetTag(string slug, CancellationToken cancellationToken = default);

    }
}
