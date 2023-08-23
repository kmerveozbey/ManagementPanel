using AutoMapper;
using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL.Implementations
{
    public class LoginActivityRepo : Repository<LoginActivityModel, Guid>
    {
        public LoginActivityRepo(MyContext myContext) : base(myContext)
        {

        }
    }
}
