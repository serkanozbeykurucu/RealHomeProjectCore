using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class PopularRentHome
    {
        public int Id { get; set; }
        public string RentHomeImage { get; set; }
        public string RentHomeName { get; set; }
        public string RentHomeDescription { get; set; }
        public int RentHomePrice { get; set; }
        public bool Status { get; set; }
    }
}
