using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApp.Entities
{
    public class UserType
    { 
        [Key]
        public int ID { get; set; }
        public string Type{ get; set; }

    }
}
