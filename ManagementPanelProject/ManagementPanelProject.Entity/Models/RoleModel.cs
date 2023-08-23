using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagementPanelProject.Entity.Models
{
    [Table("Roles")]
    public class RoleModel
    {
        [Required]
        [Display(Name = "RoleName")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string RoleName { get; set; }

        [Display(Name = "RoleDesc")]
        public string? RoleDesc { get; set; }

       
    }
}
