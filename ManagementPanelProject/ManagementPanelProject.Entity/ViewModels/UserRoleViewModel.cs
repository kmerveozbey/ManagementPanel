using ManagementPanelProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagementPanelProject.Entity.ViewModels
{
    public class UserRoleViewModel
    {

        [Required]
        [Display(Name = "User Name")]
        public string UserRoleUserName { get; set; }

        [Required]
        [Display(Name = "Role Name")]
        public string UserRoleRoleName { get; set; }

        public UserViewModel? _UserName { get; set; }

        public RoleViewModel? _RoleName { get; set; }
    }
}
