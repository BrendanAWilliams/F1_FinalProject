using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1_FinalProject.Models
{
    public class Driver
    {
        public int DriverID {get; set;} //Primary Key
        
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;}
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;}
        [Range(0,100)]
        public int Number {get; set;}
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate {get; set;}
        public string Country {get; set;}
        [Range(0,1000)]
        public int Podiums {get; set;}
        [Range(0,10000)]
        public double Points {get; set;}
        [Display(Name = "Grand Prixs Entered")]
        [Range(0,1000)]
        public int GPEntered {get; set;}
        [Range(0,100)]
        public int Championships {get; set;}

        public int TeamID {get; set;}   //Foreign Key linking Driver to Team
        public Team Team {get; set;}    //Navigation Property for Team
        public List<Circuit> Circuits {get; set;} //Navigation Property to Circuit
    }
}