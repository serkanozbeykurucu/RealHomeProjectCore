using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class Testimonial
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Appelation { get; set; } //Müşteri Unvanı
        public string Description { get; set; }
        public bool Status  { get; set; }
    }
}
