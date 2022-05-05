using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1_FinalProject.Models
{
    public class Team
    {
        public int TeamID {get; set;} //Primary Key
        [Display(Name = "Team Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string TeamName {get; set;}
        [Display(Name = "Base Location")]
        [StringLength(60, MinimumLength = 3)]
        public string Base {get; set;}
        [Display(Name = "Team Chief")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Chief {get; set;}
        [StringLength(10, MinimumLength = 3)]
        public string Chasis {get; set;}
        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "Power Unit")]
        public string PowerUnit {get; set;}
        [Display(Name = "First Entry")]
        [Range(1900,2022)]
        public int FirstEntry {get; set;}
        [Range(0,1000)]
        public int Championships {get; set;}
        [Display(Name = "Pole Positions")]
        [Range(0,10000)]
        public int PolePositions {get; set;}
        public List<Driver> Drivers {get; set;} //Navigation Property to Driver
    }
}