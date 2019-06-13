using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395887A1.Models
{
    public class VideoGame
    {

        [Key]
        public String ID { get; set; }
        [Required]
        public String Name { get; set; }
        public int Price { get; set; }
        [Required]
        public String Description { get; set; }
        [Display(Name = "Minimum Requirement")]
        public String MinRequirements { get; set; }
        [Required]
        public String Publisher { get; set; }
        [Required]
        public String Developer { get; set; }
        [Required]
        public String Genre { get; set; }
        public String Review { get; set; }
    }
}