using System;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Interface;

namespace Alpha.API.Data.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepo;

        public PaymentService(IPaymentRepository paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }

        public async Task<bool> Create(Payment payment)
        {
            if (payment != null)
            {
                await _paymentRepo.Add(payment);
            }
            return false;
        }

        public async Task<IEnumerable<Payment>> GetAll()
        {
            var paymentList = await _paymentRepo.GetAll();
            return paymentList;
        }

        public async Task<Payment> GetById(int paymentId)
        {
            if (paymentId > 0)
            {
                var payment = await _paymentRepo.GetById(paymentId);
                if (payment != null)
                {
                    return payment;
                }
            }
            return null;
        }

        public async Task<bool> Update(Payment payment)
        {
            if (payment != null)
            {
                var paymentRepo = await _paymentRepo.GetById(payment.PaymentId);
                if (paymentRepo != null)
                {
                    paymentRepo.CardType = payment.CardType;
                    paymentRepo.CardNumber = payment.CardNumber;
                    paymentRepo.ExpirationDate = payment.ExpirationDate;
                    paymentRepo.Name = payment.Name;
                    paymentRepo.SecurityCode = payment.SecurityCode;

                    _paymentRepo.Update(paymentRepo);
                }
            }
            return false;
        }

        public async Task<bool> Delete(int paymentId)
        {
            if (paymentId > 0)
            {
                var payment = await _paymentRepo.GetById(paymentId);
                if (payment != null)
                {
                    _paymentRepo.Delete(payment);
                }
            }
            return false;
        }
    }
}

