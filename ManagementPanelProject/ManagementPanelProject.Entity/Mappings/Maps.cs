using AutoMapper;
using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.Entity.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<UserModel, UserViewModel>().ReverseMap();
            CreateMap<RoleModel, RoleViewModel>().ReverseMap();
            CreateMap<LoginActivityModel, LoginActivityViewModel>().ReverseMap();
        }
    }
}
