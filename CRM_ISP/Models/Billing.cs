using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Billing
    {
        public int BillingId { get; set; }
        [Display(Name = "Billing Status")]

        public bool BillingStatus { get; set; }
        [ForeignKey("User")]

        public int? UserId { get; set; }
        [ForeignKey("Package")]
        public int? PackageId { get; set; }

        public DateTime BillingDate { get; set; } = DateTime.Now;


        public virtual Package? Package { get; set; }

        public virtual User? User { get; set; }

    }
}
