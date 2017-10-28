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
        [Display(Name = "Condition of weather? ex. Sunny, Stormy, etc")]
        public string WeatherType { get; set; }
        [Display(Name = "Condition of water? ex. Calm, Choppy, etc")]
        public string WaterCondition { get; set; }
        [Display(Name = "Rate how easy to find eligible skipping stones. 1-10")]
        public int StoneAvailability { get; set; }
        [Display(Name = "How many skips per throw did you average")]
        public int AverageSkip { get; set; }
        [MaxLength(140), Display(Name = "Any additional comments?")]
        public string Comment { get; set; }
        [Display(Name = "Rate 1-10 of overall stone skipping experience")]
        public int OverallReview { get; set; }



        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

    }
}