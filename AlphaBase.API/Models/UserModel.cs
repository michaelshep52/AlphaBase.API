using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alpha.API.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(20)]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(20)]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public string? Password { get; set; }

        // Address
        //[ForeignKey("AddressId")]
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? CityTown { get; set; }
        public string? StateProvince { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        // Email
        //[ForeignKey("EmailAddressId")]
        public ICollection<EmailAddressModel>? EmailAddress { get; set; }

        // Phone
        //[ForeignKey("PhoneId")]
        public ICollection<PhoneModel>? Phones { get; set; }

        // Payment
        //[ForeignKey("PaymentId")]
        public ICollection<PaymentModel>? Payments { get; set; }

    }
}

