using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class RegistrationMessage
    {
        public int RegistrationMessageId { get; set; }
        [Display(Name = "Message Body"), StringLength(500)]
        public string MessageBody { get; set; } = null!;
    }
}
