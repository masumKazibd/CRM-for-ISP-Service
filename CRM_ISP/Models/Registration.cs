using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Registration
    {
        public int RegistrationMessageId { get; set; }
        [Required, StringLength(200), Display(Name = "Message Body")]
        public string MessageBody { get; set; } = default!;
    }
}
