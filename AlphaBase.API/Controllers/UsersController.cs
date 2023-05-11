using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alpha.API.Data;
using Alpha.API.Data.Entities;
using Alpha.API.Data.Services.Interface;
using System.Security.Principal;
using Alpha.API.Data.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Alpha.API.Models;

namespace Alpha.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class UsersController : ControllerBase
    {
        public readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> GetUserList()
        {
            try
            {
                var usersList = await _userService.GetAll();
                if (usersList == null)
                {
                    return NotFound();
                }
                return Ok(usersList);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById(int userId)
        {
            try
            {
                var user = await _userService.GetById(userId);

                if (user != null)
                {
                    return Ok(user);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

            // POST: api/Users
        [HttpPut]
        public async Task<IActionResult> CreateUser(User user)
        {
            var isUserCreated = await _userService.Create(user);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (user != null)
            {
                var isUserCreated = await _userService.Update(user);
                if (isUserCreated)
                {
                    return Ok(isUserCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var isUserCreated = await _userService.Delete(userId);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
