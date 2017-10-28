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
        public DateTime Date { get; set; }
        public string WeatherType { get; set; }
        public string WaterCondition { get; set; }
        public int StoneAvailability { get; set; }
        public int AverageSkip { get; set; }
        [MaxLength(140)]
        public string Comment { get; set; }
        public int OverallReview { get; set; }



        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

    }
}