using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImageURL { get; set; }
        public DateTime PostDate { get; set; }
        public string UserID { get; set; }
        public int CategoryID { get; set; } 
        public BlogCategory BlogCategory { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}
