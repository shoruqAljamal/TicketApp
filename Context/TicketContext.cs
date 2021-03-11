using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Context.TicketsConfiguration;
using TicketApp.Entities;

namespace TicketApp.Context
{
    public class TicketContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            /*
             * Lazy Loading : multible querie s 
             * Eadger Loading : one query (include) 
             * */
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<User>());
            new UserTypeConfiguration(modelBuilder.Entity<UserType>());
            new TicketConfiguration(modelBuilder.Entity<Ticket>());
        }
    }
}
