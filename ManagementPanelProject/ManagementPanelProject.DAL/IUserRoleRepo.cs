using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL
{
    public interface IUserRoleRepo : IRepository<UserRoleModel, string>
    {
    }
}
