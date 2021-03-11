using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Models;

namespace TicketApp.Supervisors
{
    public partial class Supervisor 
    {
        public async Task<List<UserTypeModel>> GetAllUserTypes()
        {
            var types = await _IUserTypeRepo.GetAllUserTypes();
            return _Mapper.Map<List<UserTypeModel>>(types);

        }

        public async Task<UserTypeModel> GetUserTypeByID(int id)
        {
            var type = await _IUserTypeRepo.GetUserTypeByID(id);
            return _Mapper.Map<UserTypeModel>(type);
        }
    }
}
