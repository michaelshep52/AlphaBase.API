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
    public class EmailAddressController : ControllerBase
    {
        public readonly IEmailAddressService _emailAddressService;

        public EmailAddressController(IEmailAddressService emailAddressService)
        {
            _emailAddressService = emailAddressService;
        }

        // GET: api/EmailAddress
        [HttpGet]
        public async Task<IActionResult> GetEmailAddressList()
        {
            var emailaddressList = await _emailAddressService.GetAll();
            if (emailaddressList == null)
            {
                return NotFound();
            }
            return Ok(emailaddressList);
        }

        [HttpGet("{emailAddressId}")]
        public async Task<IActionResult> GetEmailAddressById(int emailAddressId)
        {
            var emailAddress = await _emailAddressService.GetById(emailAddressId);

            if (emailAddress != null)
            {
                return Ok(emailAddress);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: api/EmailAddress
        [HttpPut]
        public async Task<IActionResult> CreateEmailAddress(EmailAddress emailAddress)
        {
            var isEmailAddressCreated = await _emailAddressService.Create(emailAddress);

            if (isEmailAddressCreated)
            {
                return Ok(isEmailAddressCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateEmailAddress(EmailAddress emailAddress)
        {
            if (emailAddress != null)
            {
                var isEmailAddressCreated = await _emailAddressService.Update(emailAddress);
                if (isEmailAddressCreated)
                {
                    return Ok(isEmailAddressCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{emailAddressId}")]
        public async Task<IActionResult> DeleteEmailAddress(int emailAddressId)
        {
            var isEmailAddressCreated = await _emailAddressService.Delete(emailAddressId);

            if (isEmailAddressCreated)
            {
                return Ok(isEmailAddressCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
