using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.IRepos
{
    public interface IUserRepo
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByID(int id);
        Task<User> Add(User User);
        Task<User> Login(Login User);
        Task<bool> Update(User User);
        Task<bool> DeleteByID(int id);
    }
}
