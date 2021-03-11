using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;

namespace TicketApp.IRepos
{
    public interface IUserTypeRepo
    {
        Task<List<UserType>> GetAllUserTypes();
        Task<UserType> GetUserTypeByID(int id);

    }
}
