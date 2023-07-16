using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class BlogCategory
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }  
    }
}
