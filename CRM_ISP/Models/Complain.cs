using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Complain
    {
        public int ComplainId { get; set; }
        [Required, StringLength(100), Display(Name = "Complain Type")]

        public string ComplainType { get; set; } = null!;
        [Required(ErrorMessage = "Please type details"), StringLength(150), Display(Name = "Complain Details")]

        public string ComplainDetails { get; set; } = null!;
        [Required(ErrorMessage = "Please enter date"), Column(TypeName = "date"), Display(Name = "Complain Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime ComplaintDate { get; set; } = DateTime.Now;

        public virtual ICollection<ComplainStatus>? ComplainStatuses { get; set; } = new List<ComplainStatus>();

        public virtual ICollection<Feedback>? FeedBacks { get; set; } = new List<Feedback>();

        public virtual ICollection<UserComplain>? UserComplains { get; set; } = new List<UserComplain>();

    }
}
