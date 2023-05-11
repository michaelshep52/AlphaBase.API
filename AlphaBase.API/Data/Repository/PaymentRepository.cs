using System;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;
using Alpha.API.Models;

namespace Alpha.API.Data.Repository
{
    public class PaymentRepository : AlphaRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AlphaBaseContext context) : base(context)
        {
        }
    }
}

