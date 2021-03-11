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
    public class UserTypeRepo : IUserTypeRepo
    {
        private readonly TicketContext _context;
        public UserTypeRepo(TicketContext context)
        {
            _context = context;
        }
        public async Task<List<UserType>> GetAllUserTypes()
        {
            var types = await _context.UserTypes.ToListAsync();
            return types;

        }

        public async Task<UserType> GetUserTypeByID(int id)
        {
            var type = await _context.UserTypes.Where(e => e.ID == id)
                               .FirstOrDefaultAsync();
            return type;
        }
    }
}
