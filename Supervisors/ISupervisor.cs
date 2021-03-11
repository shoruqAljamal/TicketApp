using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Models;

namespace TicketApp.Supervisors
{
   public interface ISupervisor
    {

        #region User
        Task<List<UserModel>> GetAllUsers();

        Task<UserModel> GetUserByID(int id);

        Task<UserModel> AddUser(UserModel UserModel);
        Task<UserModel> LoginUser(LoginModel loginModel);

        Task<bool> UpdateUser(UserModel UserModel);

        Task<bool> DeleteUserById(int id);
        #endregion

        #region Ticket

        Task<List<TicketModel>> GetAllTickets();

        Task<TicketModel> GetTicketByID(int id);

        Task<TicketModel> AddTicket(TicketModel TicketModel);

        Task<bool> UpdateTicket(TicketModel TicketModel);

        Task<bool> DeleteTicketById(int id); 
        #endregion

    }
}
