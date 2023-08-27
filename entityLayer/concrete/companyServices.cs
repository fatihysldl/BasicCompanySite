using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class companyServices
    {
        [Key]
        public int companyServicesId { get; set; }

        [StringLength(20)]
        public string companyServicesHeader { get; set; }

        [StringLength(80)]
        public string companyServicesDescription { get; set; }
        [StringLength(150)]
        public string ımagePath { get; set; }
    }
}
