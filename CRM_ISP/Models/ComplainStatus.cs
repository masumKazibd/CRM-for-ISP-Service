using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class ComplainStatus
    {
        public int ComplainStatusId { get; set; }
        [Required, Display(Name = "Complain Status Type")]

        public bool ComplainStatusType { get; set; }
        [ForeignKey("Complain")]

        public int? ComplainId { get; set; }

        public virtual Complain? Complain { get; set; }
    }
}
