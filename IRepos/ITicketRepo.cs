using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.IRepos
{
    public interface ITicketRepo
    {
        Task<List<Ticket>> GetAllTickets();
        Task<List<Ticket>> GetTicketsByUserID(int UserId);
        Task<Ticket> GetTicketByID(int id);
        Task<Ticket> Add(Ticket Ticket);
        Task<bool> Update(Ticket Ticket);
        Task<bool> DeleteByID(int id);
    }
}
