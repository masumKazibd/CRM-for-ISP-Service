using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Role
    {
        public Role()
        {
            this.Admins = new List<Admin>();
            this.SupportEngineers = new List<SupportEngineer>();
            this.Users = new List<User>();
        }
        public int RoleId { get; set; }
        [Required, StringLength(50), Display(Name = "Role Name")]
        public string RoleName { get; set; } = default!;
        //navigation
        public virtual ICollection<Admin>? Admins { get; set; }
        public virtual ICollection<SupportEngineer>? SupportEngineers { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
