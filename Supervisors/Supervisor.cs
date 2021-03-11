using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.IRepos;
using TicketApp.Models;

namespace TicketApp.Supervisors
{
    public partial class Supervisor : ISupervisor
    {
        private readonly IUserRepo _IUserRepo;
        private readonly ITicketRepo _ITicketRepo;
        private readonly IUserTypeRepo _IUserTypeRepo;
        private readonly IMapper _Mapper;
        public Supervisor(IUserRepo IUserRepo , IUserTypeRepo IUserTypeRepo, ITicketRepo ITicketRepo, IMapper Mapper)
        {
            _IUserRepo = IUserRepo;
            _IUserTypeRepo = IUserTypeRepo;
            _ITicketRepo = ITicketRepo;
            _Mapper = Mapper;
        }

  
    }
}
