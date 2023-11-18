using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class ComplainStatus
    {
        [Display(Name = "Complain Status Id")]
        public int ComplainStatusId { get; set; }
        [Required, Display(Name = "Status Type")]
        public bool StatusType { get; set; }
        //Foreign Key
        [ForeignKey("Complain")]
        public int ComplainId { get; set; }
        public virtual Complain? Complain { get; set; }

       
    }
}
