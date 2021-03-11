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

        public async Task<List<UserModel>> GetAllUsers()
        {
            var users = await _IUserRepo.GetAllUsers();
            return _Mapper.Map<List<UserModel>>(users);

        }

        public async Task<UserModel> GetUserByID(int id)
        {
            var user = await _IUserRepo.GetUserByID(id);
            return _Mapper.Map<UserModel>(user);
        }

        public async Task<UserModel> AddUser(UserModel userModel)
        {
            var user = _Mapper.Map<User>(userModel);
            return _Mapper.Map<UserModel>(await _IUserRepo.Add(user));
        }

        public async Task<UserModel> LoginUser(LoginModel loginModel)
        {
            var user = _Mapper.Map<Login>(loginModel);

            return _Mapper.Map<UserModel>(await _IUserRepo.Login(user));
        }
        public async Task<bool> UpdateUser(UserModel UserModel)
        {
            var UserEntity = _Mapper.Map<User>(UserModel);
            return await _IUserRepo.Update(UserEntity);
        }

        public async Task<bool> DeleteUserById(int id)
        {
            try
            {
                await _IUserRepo.DeleteByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
    }
}
