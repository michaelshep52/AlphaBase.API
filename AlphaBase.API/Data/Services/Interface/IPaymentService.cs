using System;
using Alpha.API.Data.Entities;
using Alpha.API.Models;

namespace Alpha.API.Data.Services.Interface
{
    public interface IPaymentService
    {
        Task<bool> Create(Payment payment);

        Task<IEnumerable<Payment>> GetAll();

        Task<Payment> GetById(int paymentId);

        Task<bool> Update(Payment payment);

        Task<bool> Delete(int paymentId);
    }
}

