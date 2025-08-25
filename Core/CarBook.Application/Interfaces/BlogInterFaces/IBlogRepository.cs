using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarbook.Domain.Entities;

namespace CarBook.Application.Interfaces.BlogInterFaces
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogsWithAuthors();

    }
}
