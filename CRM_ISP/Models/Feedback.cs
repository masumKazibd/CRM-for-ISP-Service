using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        [Required, StringLength(50)]
        public string Rating { get; set; } = default!;
        [Required, StringLength(50), Display(Name = "Rating Message")]
        public string RatingMessage { get; set; } = default!;
        //Foreign Key
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Complain")]
        public int ComplainId { get; set; }


        public virtual User? User { get; set; }
        public virtual Complain? Complain { get; set; }

        

       

    }
}
