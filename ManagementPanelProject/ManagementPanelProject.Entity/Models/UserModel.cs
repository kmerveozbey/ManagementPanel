using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementPanelProject.Entity.Models
{
    [Table("Users")]
    public class UserModel
    {
        [Required]
        [Display(Name = "UserName")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Phone]
        [Display(Name = "Phone")]
        public string? Phone { get; set; }

        [Display(Name = "Birthday")]
        public DateTime? Birthday { get; set; }


        [Display(Name = "School")]
        public string? School { get; set; }


        [Display(Name = "ExperienceYear")]
        public int? ExperienceYear { get; set; }


    }
}
