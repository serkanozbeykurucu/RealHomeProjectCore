using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Entities.Concrete
{
    public class CompanyService
    {
        public int ID { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public bool Status { get; set; }
    }
}
