using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Entities;
using TicketApp.Models;

namespace TicketApp.Mapper
{
   public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<UserType, UserTypeModel>().ReverseMap();
            CreateMap<Ticket, TicketModel>().ReverseMap();
            CreateMap<Login, LoginModel>().ReverseMap();
        }
    }
}
