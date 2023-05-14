using System.ComponentModel.DataAnnotations;

namespace Alpha.API.Data.Entities
{
    public class Address
    {
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string? CityTown { get; set; }

        [Required(ErrorMessage = "State is required")]
        public string? StateProvince { get; set; }

        [Required(ErrorMessage = "Postal is required")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string? Country { get; set; }
    }
}

