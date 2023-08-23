using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL.Implementations
{
    public class RoleRepo : Repository<RoleModel, string>
    {
        public RoleRepo(MyContext myContext) : base(myContext)
        {

        }
    }
}
