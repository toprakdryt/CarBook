using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarbook.Domain.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}
