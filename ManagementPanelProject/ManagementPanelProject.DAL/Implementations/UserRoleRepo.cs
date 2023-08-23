using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL.Implementations
{
    public class UserRoleRepo : Repository<UserRoleModel, string>
    {
        public UserRoleRepo(MyContext myContext) : base(myContext)
        {

        }
    }
}
