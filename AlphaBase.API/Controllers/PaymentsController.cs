using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Alpha.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PaymentsController : ControllerBase
    {
        public readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        // GET: api/Payment
        [HttpGet]
        public async Task<IActionResult> GetPaymentList()
        {
            var paymentList = await _paymentService.GetAll();
            if (paymentList == null)
            {
                return NotFound();
            }
            return Ok(paymentList);
        }

        [HttpGet("{paymentId}")]
        public async Task<IActionResult> GePaymentById(int paymentId)
        {
            var payment = await _paymentService.GetById(paymentId);

            if (payment != null)
            {
                return Ok(payment);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: api/Payment
        [HttpPut]
        public async Task<IActionResult> CreatePayment(Payment payment)
        {
            var isPaymentCreated = await _paymentService.Create(payment);

            if (isPaymentCreated)
            {
                return Ok(isPaymentCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdatePayment(Payment payment)
        {
            if (payment != null)
            {
                var isPaymentCreated = await _paymentService.Update(payment);
                if (isPaymentCreated)
                {
                    return Ok(isPaymentCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{paymentId}")]
        public async Task<IActionResult> DeletePayment(int paymentId)
        {
            var isPaymentCreated = await _paymentService.Delete(paymentId);

            if (isPaymentCreated)
            {
                return Ok(isPaymentCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

