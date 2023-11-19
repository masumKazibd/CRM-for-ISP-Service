using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class City
    {
        public City()
        {
            this.Users = new List<User>();
        }
        public int CityId { get; set; }
        [Required, Display(Name = "City Name")]
        public string CityName { get; set; } = default!;

        public virtual ICollection<User>? Users { get; set; }
    }
}
