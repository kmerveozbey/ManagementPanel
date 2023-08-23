using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagementPanelProject.Entity.ViewModels
{
    public class RoleViewModel
    {

        [Required]
        [Display(Name = "RoleName")]
        public string? RoleName { get; set; }

        [Required]
        [Display(Name = "RoleDesc")]
        public string RoleDesc { get; set; }
    }
}
