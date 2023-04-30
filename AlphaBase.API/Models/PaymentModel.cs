using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Models
{
    public class PaymentModel
    {
        [Required(ErrorMessage = "Card Type is required")]
        [DisplayName("Card Type")]
        [DataType(DataType.CreditCard)]
        [StringLength(20)]
        public string? CardType { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [DisplayName("Card Number")]
        [StringLength(16)]
        public int CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration date is required")]
        [DisplayName("Expiration date")]
        [StringLength(8)]
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "Card Holders Name is required")]
        [DisplayName("Card Holders Name")]
        [StringLength(80)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Security code is required")]
        [DisplayName("Security Code")]
        [StringLength(4)]
        public int SecurityCode { get; set; }
    }
}

