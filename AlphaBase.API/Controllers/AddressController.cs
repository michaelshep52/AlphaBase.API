using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public class AddressController : ControllerBase
    {
        public readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetAddressList()
        {
            var addressList = await _addressService.GetAll();
            if (addressList == null)
            {
                return NotFound();
            }
            return Ok(addressList);
        }

        [HttpGet("{addressId}")]
        public async Task<IActionResult> GetAddressById(int addressId)
        {
            var address = await _addressService.GetById(addressId);

            if (address != null)
            {
                return Ok(address);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: api/Users
        [HttpPut]
        public async Task<IActionResult> CreateAddress(Address address)
        {
            var isAddressCreated = await _addressService.Create(address);

            if (isAddressCreated)
            {
                return Ok(isAddressCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateUser(Address address)
        {
            if (address != null)
            {
                var isAddressCreated = await _addressService.Update(address);
                if (isAddressCreated)
                {
                    return Ok(isAddressCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{addressId}")]
        public async Task<IActionResult> DeleteUser(int addressId)
        {
            var isAddressCreated = await _addressService.Delete(addressId);

            if (isAddressCreated)
            {
                return Ok(isAddressCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
