using ManagementPanelProject.Entity.Models;
using ManagementPanelProject.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.DAL
{
    public interface ILoginActivityListRepo : IRepository<LoginActivityModel, Guid>
    {

    }
}
