using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Interfaces.TagCloudInterFaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudsByBlogID(int id);
    }
}
