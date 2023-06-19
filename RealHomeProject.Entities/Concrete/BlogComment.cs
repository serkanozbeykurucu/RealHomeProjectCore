using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class BlogComment
    {
        public int ID { get; set; }
        public string NameSurname { get; set; }    
        public string Email { get; set; }    
        public string Subject { get; set; }    
        public string CommentText { get; set; }
        public string BlogPostID { get; set; }
        public BlogPost BlogPost { get; set; }
        public bool Status { get; set; }
    }
}
