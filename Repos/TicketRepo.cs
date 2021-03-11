using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Context;
using TicketApp.Entities;
using TicketApp.IRepos;

namespace TicketApp.Repos
{

    public class TicketRepo  : ITicketRepo
    {

        private readonly TicketContext _context;
        public TicketRepo(TicketContext context)
        {
            _context = context;
        }
        public async Task<Ticket> Add(Ticket Ticket)
        {
            _context.Add(Ticket); //Change Tracker : only change the state 
            await _context.SaveChangesAsync();
            return Ticket;
        }

        public async Task<bool> DeleteByID(int id)
        {
            var ticket = await GetTicketByID(id);
            _context.Remove(ticket); //Change Tracker : only change the state 
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }

        public async Task<List<Ticket>> GetAllTickets()
        {
            var tickets = await _context.Tickets.ToListAsync();
            return tickets;
        }

        public async Task<Ticket> GetTicketByID(int id)
        {
            var ticket = await _context.Tickets.Where(e => e.ID == id)
                                        .Include(e => e.User)
                                        .FirstOrDefaultAsync();
            return ticket;
        }

        public async Task<List<Ticket>> GetTicketsByUserID(int UserId)
        {

            var tickets = await _context.Tickets
                                         .Where(e=>e.UserId == UserId)
                                         .ToListAsync();
            return tickets;
        }

        public async Task<bool> Update(Ticket Ticket)
        {
            _context.Update(Ticket); //Change Tracker : only change the state 
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }
            return true;
        }
    }
}
