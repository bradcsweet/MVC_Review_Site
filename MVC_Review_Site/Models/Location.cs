using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Review_Site.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Body of Water")]
        public string BodyOfWater { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

    }
}