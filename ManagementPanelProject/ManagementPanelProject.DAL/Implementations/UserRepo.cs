﻿using ManagementPanelProject.DAL.ContextInfo;
using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL.Implementations
{
    public class UserRepo : Repository<UserModel, string>, IUserRepo
    {
        public UserRepo(MyContext myContext) : base(myContext)
        {

        }
    }
}
