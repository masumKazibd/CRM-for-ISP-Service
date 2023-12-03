using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required(ErrorMessage = "City name is required"), StringLength(50), Display(Name = "City Name")]

        public string CityName { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; } = new List<User>();
    }
}
