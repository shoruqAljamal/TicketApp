using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.Context.TicketsConfiguration
{
    public class UserTypeConfiguration
    {
        public UserTypeConfiguration(EntityTypeBuilder<UserType> entity)
        {
            entity.HasData(
                new UserType()
                {
                    ID = 1, 
                    Type = "Admin"

                },
                new UserType()
                 {
                     ID = 2,
                     Type = "Client"
                }
                );
        }
    }
}
