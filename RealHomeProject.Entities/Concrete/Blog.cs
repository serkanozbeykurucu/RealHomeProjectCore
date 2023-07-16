using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImageURL { get; set; }
        public DateTime PostDate { get; set; }
        public int AppUserId { get; set; }
        public virtual AppUser? AppUser { get; set; }
        public int BlogCategoriesID { get; set; } 
        public virtual BlogCategory? BlogCategories { get; set; }
        public virtual ICollection<BlogComment> BlogComment { get;}
    }
}
