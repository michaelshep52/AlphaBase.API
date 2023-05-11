using System;
namespace Alpha.API.Data.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        // 1 User to Many forms of payment
        public User? User { get; set; } 
    }
}

