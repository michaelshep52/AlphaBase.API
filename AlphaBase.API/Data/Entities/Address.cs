using System;

namespace Alpha.API.Data.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? CityTown { get; set; }
        public string? StateProvince { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        // 1 User to 1 Address
        public virtual User? User { get; set; }
        public int UserId { get; set; }
    }
}

