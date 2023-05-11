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
    public class PhonesController : ControllerBase
    {
        public readonly IPhoneService _phoneService;

        public PhonesController(IPhoneService phoneService)
        {
            _phoneService = phoneService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetPhoneList()
        {
            var phoneList = await _phoneService.GetAll();
            if (phoneList == null)
            {
                return NotFound();
            }
            return Ok(phoneList);
        }

        [HttpGet("{phoneId}")]
        public async Task<IActionResult> GetPhoneById(int phoneId)
        {
            var phone = await _phoneService.GetById(phoneId);

            if (phone != null)
            {
                return Ok(phone);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: api/Phone
        [HttpPut]
        public async Task<IActionResult> CreatePhone(Phone phone)
        {
            var isPhoneCreated = await _phoneService.Create(phone);

            if (isPhoneCreated)
            {
                return Ok(isPhoneCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdatePhone(Phone phone)
        {
            if (phone != null)
            {
                var isPhoneCreated = await _phoneService.Update(phone);
                if (isPhoneCreated)
                {
                    return Ok(isPhoneCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{phoneId}")]
        public async Task<IActionResult> DeletePhone(int phoneId)
        {
            var isPhoneCreated = await _phoneService.Delete(phoneId);

            if (isPhoneCreated)
            {
                return Ok(isPhoneCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
