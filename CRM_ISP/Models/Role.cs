using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Display(Name = "Role Name"), StringLength(50)]
        public string RoleName { get; set; } = null!;

        public virtual ICollection<Admin>? Admins { get; set; } = new List<Admin>();

        public virtual ICollection<SupportEngineer>? SupportEngineers { get; set; } = new List<SupportEngineer>();

        public virtual ICollection<User>? Users { get; set; } = new List<User>();

    }
}
