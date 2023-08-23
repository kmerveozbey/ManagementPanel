using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManagementPanelProject.Entity.ViewModels
{
    public class UserViewModel
    {

        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Display(Name = "Surname")]
        public string? Surname { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Display(Name = "Birthday")]
        public string? Birthday { get; set; }

        [Display(Name = "School")]
        public string? School { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "ExperienceYear")]
        public int? ExperienceYear { get; set; }

    }
}
