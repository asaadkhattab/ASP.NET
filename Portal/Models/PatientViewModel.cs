﻿
using System.ComponentModel.DataAnnotations;
 


namespace Portal.Models
{
    public class PatientViewModel
    {
        public int? PatientId { get; set; }

        public string Prefix { get; set; }

        [Required(ErrorMessage = "First Name is Required.")]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is Required.")]
        public string LastName { get; set; }

        public string Suffix { get; set; }

        public int AccountBalance { get; set; }

   
        public string FullName => FirstName + " " + LastName;

 
        public MedicationViewModel Medication { get; set; }

 
 
    }
}