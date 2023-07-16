using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Dto.Dtos.BlogDTOs
{
	public class BlogListDto
	{
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlogImageURL { get; set; }
        public DateTime PostDate { get; set; }
        public int AppUserId { get; set; }
        public int BlogCategoriesID { get; set; }
    }
}
