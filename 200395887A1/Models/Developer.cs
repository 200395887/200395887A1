﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200395887A1.Models
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Website { get; set; }
    }
}