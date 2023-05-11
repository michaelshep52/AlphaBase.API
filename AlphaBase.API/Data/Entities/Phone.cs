using System;
namespace Alpha.API.Data.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string? PhoneNumber { get; set; }

        // 1 User to Many Phone numbers
        public User? User { get; set; }
    }
}

