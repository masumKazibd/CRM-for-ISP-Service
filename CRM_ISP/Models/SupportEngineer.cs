using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class SupportEngineer
    {
        public int SupportEngineerId { get; set; }
        [Required, Display(Name = "SupportEngineer Name")]
        public string SupportEngineerName { get; set; } = default!;
        [Required, Display(Name = "SupportEngineer Email")]
        public string SupportEngineerEmail { get; set; } = default!;
        [Required, Display(Name = "SupportEngineer JoinDate"), Column("date")]
        public DateTime SupportEngineerJoinDate { get; set; }
        [Required, Display(Name = "SupportEngineer Gender")]
        public string SupportEngineerGender { get; set; } = default!;
        [Required, Display(Name = "SupportEngineer Phone")]
        public int SupportEngineerPhone { get; set; }
        [Required, Display(Name = "SupportEngineer Password")]
        public string SupportEngineerPassword { get; set; } = default!;

        //foreign key
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual Area? Area { get; set; }
        public virtual Role? Role { get; set; }

       

    }
}
