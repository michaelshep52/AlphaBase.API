using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Data.Entities
{
    public class EmailAddress
    {
        public int EmailAddressId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        // 1 User to Many Emails
        public User? User { get; set; }        
    }
}

