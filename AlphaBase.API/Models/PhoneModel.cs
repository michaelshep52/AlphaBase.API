using System;
using System.ComponentModel.DataAnnotations;
using Alpha.API.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alpha.API.Models
{
    public class PhoneModel
    {
        [Key]
        public int PhoneId { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public string? PhoneNumber { get; set; }
    }
}

