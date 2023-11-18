using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Billing
    {
        public int BillingId { get; set; }
        public bool Status { get; set; } = false;
        //Forign Key
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Package")]
        public int PackageId { get; set; }
        public virtual User? User { get; set; } 
        public virtual Package? Package { get; set; }
         
       
    }
}
