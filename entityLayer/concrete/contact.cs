using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class contact
    {
        [Key]
        public int contactId { get; set; }

        [StringLength(30)]
        public string senderName { get; set; }
        
        [StringLength(30)]
        public string senderSurname { get; set; }

        [StringLength(90)]
        public string senderMail { get; set; }


        public string message { get; set; }
    }
}
