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
    public class UserRepo : IUserRepo
    {
        private readonly TicketContext _context;
        public UserRepo(TicketContext context)
        {
            _context = context;
        }
        public async Task<User> Add(User User)
        {
            _context.Add(User); //Change Tracker : only change the state 
            await _context.SaveChangesAsync();
            return User;
        }
        public async Task<User> Login(Login User)
        {
            var user = await _context.Users
                                     .Where(e => e.EmailAddress == User.EmailAddress && e.Password == User.Password)
                                      .FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> DeleteByID(int id)
        {
            var user = await GetUserByID(id);
            _context.Remove(user); //Change Tracker : only change the state 
            var success = await _context.SaveChangesAsync();
            if (success == 0)
                return false;
            return true;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserByID(int id)
        {
            var user = await _context.Users.Where(e => e.ID == id)
                                        .Include(e => e.UserType)
                                        .FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> Update(User User)
        {
            _context.Update(User); //Change Tracker : only change the state 
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
