using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Site.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Season { get; set; }


        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }
        
    }
}