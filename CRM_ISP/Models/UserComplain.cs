using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class UserComplain
    {
        public int UserComplainId { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        [ForeignKey("Complain")]
        public int? ComplainId { get; set; }
        [ForeignKey("Package")]
        public int? PackageId { get; set; }

        public DateTime UserComplainDate { get; set; } = DateTime.Now;

        public virtual Complain? Complain { get; set; }

        public virtual Package? Package { get; set; }

        public virtual User? User { get; set; }
    }
}
