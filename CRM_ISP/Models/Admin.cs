using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Required(ErrorMessage = "Admin name is required"), StringLength(50), Display(Name = "Admin Name")]

        public string AdminName { get; set; } = null!;

        [Required(ErrorMessage = "Admin Email is required"), StringLength(50), Display(Name = "Admin Email")]
        public string AdminEmail { get; set; } = null!;

        [Required(ErrorMessage = "Gender is required"), StringLength(20)]

        public string Gender { get; set; } = null!;
        [Required(ErrorMessage = "Join Date is required"), Column(TypeName = "date"), Display(Name = "Join Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime JoinDate { get; set; }

        [Required(ErrorMessage = "Image is required"), Display(Name = "Admin Image")]
        public string? AdminImage { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required")]

        public int Phone { get; set; }
        [Required(ErrorMessage = "Please type Password"), StringLength(20)]

        public string Password { get; set; } = null!;

        public DateTime AdminCreateDate { get; set; } = DateTime.Now;

        [ForeignKey("Role")]

        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }

    }
}
