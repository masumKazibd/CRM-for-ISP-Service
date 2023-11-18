using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [Required, Display(Name = "Admin Name")]
        public string AdminName { get; set; } = default!;
        [Required, Display(Name = "Admin Gender")]
        public string AdminGender { get; set; } = default!;
        [Required, Display(Name = "Admin JoinDate"), Column("date")]
        public DateTime AdminJoinDate { get; set; }
        [Required, Display(Name = "Admin Phone")]
        public int AdminPhone { get; set; }
        [Required, Display(Name = "Admin Password")]
        public int AdminPassword { get; set; }

        //foreign key
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }


    }
}
