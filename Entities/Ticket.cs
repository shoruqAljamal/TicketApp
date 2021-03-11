using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApp.Entities
{
    public class Ticket
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string Description { get; set; }
        public string StartingLocation { get; set; }
        public string DestinationLocation { get; set; }
        public int UserId { get; set; }
        public User User{ get; set; }





    }
}
