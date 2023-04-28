using System;
namespace Alpha.API.Data.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string? CardType { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Name { get; set; }
        public int SecurityCode { get; set; }

        // 1 User to Many forms of payment
        public virtual User? User { get; set; } 
        public int? UserId { get; set; }
    }
}

