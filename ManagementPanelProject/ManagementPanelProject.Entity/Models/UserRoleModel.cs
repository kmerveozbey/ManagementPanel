using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagementPanelProject.Entity.Models
{
    [Table("UserRole")]

    public class UserRoleModel
    {

        public string UserRoleUserName { get; set; }

        [ForeignKey("UserRoleUserName")]
        public virtual UserModel User { get; set; } = new UserModel();

        
        public string UserRoleRoleName { get; set; }

        [ForeignKey("UserRoleRoleName")]
        public virtual RoleModel Role { get; set; } = new RoleModel();


    }
}
