using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class SupportEngineer
    {
        public int SupportEngineerId { get; set; }
        [Required(ErrorMessage = " Engineer Name is required"), Display(Name = "Engineer Name"), StringLength(50)]

        public string EngineerName { get; set; } = null!;
        [Display(Name = "Engineer Email"), StringLength(100,MinimumLength =10)]
        public string EngineerEmail { get; set; } = null!;

        [Required(ErrorMessage = "JoinDate is required"), Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true), Display(Name = "Engineer Join Date")]
        public DateTime EngineerJoinDate { get; set; }

        [Required(ErrorMessage = "Gender is required"), Display(Name = "Engineer Gender"), StringLength(50)]
        public string EngineerGender { get; set; } = null!;


        [Required(ErrorMessage = "Support Engineer Image is required"), Display(Name = "Support Engineer Image")]
        public string SupportEngineerImage { get; set; } = null!;


        [Required(ErrorMessage = " Phone number is required"), Display(Name = "Engineer Phone"), StringLength(50)]
        public int EngineerPhone { get; set; }

        [Required(ErrorMessage = " Password is required"), Display(Name = "Engineer Password"), StringLength(50)]
        public string EngineerPassword { get; set; } = null!;

        public DateTime SupportEngineerCreateDate { get; set; } = DateTime.Now;

        [ForeignKey("Area")]
        public int? AreaId { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }

        public virtual Area? Area { get; set; }

        public virtual Role? Role { get; set; }

    }
}
