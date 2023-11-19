using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class UserComplain
    {
        public int UserComplainId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Complain")]
        public int ComplainId { get; set; }

        public virtual User? User { get; set; }
        public virtual Complain? Complain { get; set; }
    }
}
