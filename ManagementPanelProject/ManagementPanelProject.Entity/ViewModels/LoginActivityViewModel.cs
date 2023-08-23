using ManagementPanelProject.Entity.Models;
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
    public class LoginActivityViewModel
    {

        [Required]
        [Display(Name = "LoginActivityID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LoginActivityID { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "LoginDate")]
        public DateTime LogInDate { get; set; }

        [Required]
        [Display(Name = "LogoutDate")]
        public DateTime LogoutDate { get; set; }

        [Required]
        [Display(Name = "LoginStatus")]
        public Boolean LoginStatus { get; set; }

        [Required]
        [Display(Name = "LoginIsActive")]
        public Boolean LoginIsActive { get; set; }
    }
}
