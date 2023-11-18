using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [Required, StringLength(50), Display(Name = "Role Name")]
        public string RoleName { get; set; } = default!;
        //navigation
        public virtual ICollection<Admin>? Admins { get; set; }
        public virtual ICollection<SupportEngineer>? SupportEngineers { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
