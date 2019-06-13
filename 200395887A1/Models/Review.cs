using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395887A1.Models
{
    public class Review
    {
        [Key]
        public int ReviewsId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Subject { get; set; }
        [Required]
        public String Reviews { get; set; }
        [Display(Name = "Number Of Stars")]
        [Range(1,5)]
        public int NoOfStars { get; set; }

    }
}