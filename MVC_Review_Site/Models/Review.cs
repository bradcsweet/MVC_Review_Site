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
        [Display(Name = "City / State")]
        public string CityState { get; set; }
        [Display(Name = "Weather Condition")]
        public string WeatherType { get; set; }
        [Display(Name = "Water Temperment")]
        public string WaterCondition { get; set; }
        [Display(Name = "Stone Availibility Rating: 1-10")]
        public int StoneAvailability { get; set; }
        [Display(Name = "Average Skips Per Throw")]
        public int AverageSkip { get; set; }
        [MaxLength(140), Display(Name = "Additional Comments")]
        public string Comment { get; set; }
        [Display(Name = "Overall Experience Rating: 1-10")]
        public int OverallReview { get; set; }



        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

    }
}