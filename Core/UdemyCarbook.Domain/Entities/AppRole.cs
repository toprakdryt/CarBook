using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace Carbook.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleID { get; set; }
        public string AppRoleName { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}