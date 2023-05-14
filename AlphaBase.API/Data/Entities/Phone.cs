using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Data.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public string? PhoneNumber { get; set; }

        // 1 User to Many Phone numbers
        public User? User { get; set; }
    }
}

