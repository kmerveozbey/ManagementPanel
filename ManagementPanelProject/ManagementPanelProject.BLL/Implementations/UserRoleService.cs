using AutoMapper;
using ManagementPanelProject.DAL;
using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.BLL.Implementations
{
    public class UserRoleService : Service<UserRoleViewModel, UserRoleModel, string>, IUserRoleService
    {
        public UserRoleService(IMapper mapper, IUserRoleRepo repo) : base(mapper, repo)
        {

        }
    }
}