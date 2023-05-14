using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(30)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(30)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(30)]
        public string? Password { get; set; }
      
        public Address? Address { get; set; } // 1 to 1
        public List<EmailAddress> EmailAddress { get; set; } = new List<EmailAddress>(); // 1 to many
        public List<Phone> Phones { get; set; } = new List<Phone>(); // 1 to many
        public List<Payment> Payments { get; set; } = new List<Payment>(); // 1 to many
    }
}

