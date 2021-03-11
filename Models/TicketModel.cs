using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApp.Models
{
    public class TicketModel
    {


        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string Description { get; set; }
        public string StartingLocation { get; set; }
        public string DestinationLocation { get; set; }
        public int UserId { get; set; }

    }
}
