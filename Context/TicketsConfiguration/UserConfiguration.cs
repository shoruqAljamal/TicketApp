using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.Context.TicketsConfiguration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> entity)
        {
            entity.HasIndex(e => new { e.EmailAddress}).IsUnique();
            entity.HasOne<UserType>(e => e.UserType)
                  .WithMany()
                  .HasForeignKey(e => e.UserTypeId)
                  .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);


            entity.HasData(
                new User()
                {
                    ID=1,
                    UserName="shoruq",
                    Password="admin12A*",
                    EmailAddress = "admin@admin.com",
                    DateOfBirth = new DateTime(1997,10 , 9),
                    Gender ="Female", 
                    UserTypeId = 1

                },
               new User()
               {
                   ID = 2,
                   UserName = "anas",
                   Password = "anas12A*",
                   EmailAddress = "anas@ticket.com",
                   DateOfBirth = new DateTime(1998,3 ,15),
                   Gender = "male",
                   UserTypeId = 2

               },
               new User()
               {
                   ID = 3,
                   UserName = "ahmad",
                   Password = "ahmad12A*",
                   EmailAddress = "ahmad@ticket.com",
                   DateOfBirth = new DateTime(1996, 3, 15),
                   Gender = "male",
                   UserTypeId = 2

               }
                );
        }
    }
}
