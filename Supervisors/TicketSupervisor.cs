using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;
using TicketApp.Models;

namespace TicketApp.Supervisors
{
    public partial class Supervisor
    {

        public async Task<List<TicketModel>> GetAllTickets()
        {
            var tickets = await _ITicketRepo.GetAllTickets();
            return _Mapper.Map<List<TicketModel>>(tickets);

        }

        public async Task<TicketModel> GetTicketByID(int id)
        {
            var ticket = await _ITicketRepo.GetTicketByID(id);
            return _Mapper.Map<TicketModel>(ticket);
        }

        public async Task<TicketModel> AddTicket(TicketModel TicketModel)
        {
            var ticket = _Mapper.Map<Ticket>(TicketModel);
            return _Mapper.Map<TicketModel>(await _ITicketRepo.Add(ticket));
        }
        public async Task<bool> UpdateTicket(TicketModel TicketModel)
        {
            var TicketEntity = _Mapper.Map<Ticket>(TicketModel);
            return await _ITicketRepo.Update(TicketEntity);
        }

        public async Task<bool> DeleteTicketById(int id)
        {
            try
            {
                await _ITicketRepo.DeleteByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}

