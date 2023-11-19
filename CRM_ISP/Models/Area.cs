﻿using System.ComponentModel.DataAnnotations;

namespace CRM_ISP.Models
{
    public class Area
    {
        public Area()
        {
            //this.Complains =  new List<Complain>();
            this.SupportEngineers = new List<SupportEngineer>();
            this.Users = new List<User>();
        }
        public int AreaId { get; set; }
        [Required, Display(Name = "Area Name")]
        public string AreaName { get; set; } = default!;
        [Required, Display(Name = "Post Code")]
        public string PostCode { get; set; } = default!;

        //public virtual ICollection<Complain>? Complains { get; set; }
        public virtual ICollection<SupportEngineer>? SupportEngineers { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
