using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.BLL
{
    public interface IUserService : IService<UserViewModel, string>
    {
    }
}
