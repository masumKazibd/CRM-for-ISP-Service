using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Feedback
    {
        public int FeedBackId { get; set; }
        [StringLength(50)]

        public string Rating { get; set; } = null!;
        [StringLength(50), Display(Name = "Rating Message")]

        public string RatingMessage { get; set; } = null!;
        [ForeignKey("User")]

        public int? UserId { get; set; }
        [ForeignKey("Complain")]
        public int? ComplainId { get; set; }

        public DateTime FeedbackDate { get; set; } = DateTime.Now;


        public virtual Complain? Complain { get; set; }

        public virtual User? User { get; set; }

    }
}
