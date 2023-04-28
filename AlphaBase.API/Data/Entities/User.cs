using System;
namespace Alpha.API.Data.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }

        public virtual Address? Address { get; set; } // 1 to 1
        public List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>(); // 1 to many
        public List<Phone> Phones { get; set; } = new List<Phone>(); // 1 to many
        public List<Payment> Payment { get; set; } = new List<Payment>(); // 1 to many


    }
}

