using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class UserPackage
    {
        public int UserPackageId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Package")]
        public int PackageId { get; set; }
        public DateTime PackageStartDate { get; set; } = DateTime.Now;



        public virtual User? User { get; set; }  
        public virtual Package? Package { get; set; }


    }
}
