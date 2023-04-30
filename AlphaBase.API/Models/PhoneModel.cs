using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Models
{
    public class PhoneModel
    {
        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public int PhoneNumber { get; set; }
    }
}

