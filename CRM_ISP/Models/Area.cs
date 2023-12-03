using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        [Required(ErrorMessage = "Area name is required"), StringLength(70), Display(Name = "Area Name")]

        public string AreaName { get; set; } = null!;
        [Display(Name = "Post Code")]

        public int PostCode { get; set; }

        public virtual ICollection<SupportEngineer>? SupportEngineers { get; set; } = new List<SupportEngineer>();

        public virtual ICollection<User>? Users { get; set; } = new List<User>();

    }
}
