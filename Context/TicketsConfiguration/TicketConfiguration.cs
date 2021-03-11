using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.Context.TicketsConfiguration
{
    public class TicketConfiguration
    {
        public TicketConfiguration(EntityTypeBuilder<Ticket> entity)
        {
            entity.HasOne<User>(e => e.User)
                 .WithMany(u=>u.Tickets)
                 .HasForeignKey(e => e.UserId)
                 .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
            entity.HasData(
                
                new Ticket()
                {
                    ID = 1, 
                    Name = "Work",
                    TravelDate = new DateTime(2020 , 4,4),
                    ExpDate = new DateTime(2020,3,30) , 
                    StartingLocation = "Queen Alia",
                    DestinationLocation ="Istanbul" , 
                    Description ="Work Travel(conference in istanbul)",
                    UserId = 2
                },
                new Ticket()
                {
                    ID = 2,
                    Name = "Recreation",
                    TravelDate = new DateTime(2020, 8,9), 
                    ExpDate = new DateTime(2020, 7,7),
                    StartingLocation = "Queen Alia",
                    DestinationLocation = "Ankara",
                    Description = "Recreation Travel",
                    UserId = 2
                },
                new Ticket()
                {
                    ID = 3,
                    Name = "work",
                    TravelDate = new DateTime(2020, 3,3),
                    ExpDate = new DateTime(2020, 3,2),
                    StartingLocation = "Queen Alia",
                    DestinationLocation = "Cairo",
                    Description = "Work Travel",
                    UserId = 3
                },
                new Ticket()
                {
                    ID = 4,
                    Name = "History",
                    TravelDate = new DateTime(2020, 5,6),
                    ExpDate = new DateTime(2020, 4,6),
                    StartingLocation = "Queen Alia",
                    DestinationLocation = "Moroco",
                    Description = "Discover Travel",
                    UserId = 3
                }

                );
        }
       
    }
}
