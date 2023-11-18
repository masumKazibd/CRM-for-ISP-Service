using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ISP.Models
{
    public class Complain
    {
        public int ComplainId { get; set; }
        [Required, Display(Name = "Complain Type")]
        public string ComplainType { get; set; } = default!;
        [Required, Display(Name = "Complain Details")]
        public string ComplainDetails { get; set; } = default!;
        public DateTime ComplainDate { get; set; } = DateTime.Now;

        //Foreign Key
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Area")]
        public int AreaId { get; set; }


        public  virtual User? User { get; set; }
        public virtual Area? Area { get; set; }

        public virtual ICollection<ComplainStatus>? ComplainStatuses { get; set; }

        public virtual ICollection<Feedback>? Feedbacks { get; set; }



    }
}
