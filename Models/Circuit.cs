using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1_FinalProject.Models
{
    public class Circuit 
    {
        public int CircuitID {get; set;}    //Primary Key
        [Display(Name = "Grand Prix Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string GPName {get; set;}
        [Display(Name = "Circuit Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CircuitName {get; set;}
        [StringLength(60, MinimumLength = 3)]
        public string Location {get; set;}
        [Display(Name = "First Grand Prix")]
        [Range(1900,2022)]
        public int FirstGP {get; set;}
        [Range(1,100)]
        public double Length {get; set;}
        [Display(Name = "Lap Record")]
        [StringLength(10, MinimumLength = 3)]
        public string LapRecord {get; set;}
        public int DriverID {get; set;}     //Foreign Key linking Circuit to Driver
        public Driver Driver {get; set;}    //Navigation Property

    }
}