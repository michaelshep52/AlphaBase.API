using System;
namespace Alpha.API.Data.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public int PhoneNumber { get; set; }

        // 1 User to Many Phone numbers
        public virtual User? User { get; set; }
        public int? UserId { get; set; }        
    }
}

