using System;
using Alpha.API.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alpha.API.Models
{
    public class PaymentModel
    {
        public int PaymentId { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }
}

