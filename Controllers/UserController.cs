using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApp.Models;
using TicketApp.Supervisors;

namespace TicketApp.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ISupervisor _ISupervisor;
        public UserController(ISupervisor ISupervisor)
        {
            _ISupervisor = ISupervisor;
        }

        [HttpGet("GetAllUsers")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _ISupervisor.GetAllUsers();
            return Ok(result);
        }

        [HttpGet("GetUserById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _ISupervisor.GetUserByID(id);
            return Ok(result);
        }

        [HttpPost("AddUser")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> AddUser([FromBody] UserModel User)
        {
            try
            {
                var result = await _ISupervisor.AddUser(User);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost("Login")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> Login([FromBody] LoginModel User)
        {
            try
            {
                var result = await _ISupervisor.LoginUser(User);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPut("UpdateUser")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel User)
        {
            try
            {
                var result = await _ISupervisor.UpdateUser(User);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteUserById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            var result = await _ISupervisor.DeleteUserById(id);
            return Ok(result);
        }
    }
}
