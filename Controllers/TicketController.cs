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
    [Route("api/Ticket")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly ISupervisor _ISupervisor;
        public TicketController(ISupervisor ISupervisor)
        {
            _ISupervisor = ISupervisor;
        }

        [HttpGet("GetAllTickets")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetAllTickets()
        {
            var result = await _ISupervisor.GetAllTickets();
            return Ok(result);
        }

        [HttpGet("GetTicketById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> GetTicketById(int id)
        {
            var result = await _ISupervisor.GetTicketByID(id);
            return Ok(result);
        }

        [HttpPost("AddTicket")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> AddTicket([FromBody] TicketModel Ticket)
        {
            try
            {
                var result = await _ISupervisor.AddTicket(Ticket);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateTicket")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> UpdateTicket([FromBody] TicketModel Ticket)
        {
            try
            {
                var result = await _ISupervisor.UpdateTicket(Ticket);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("DeleteTicketById/{id}")]
        [EnableCors("TheCodeBuzzPolicy")]
        public async Task<IActionResult> DeleteTicketById(int id)
        {
            var result = await _ISupervisor.DeleteTicketById(id);
            return Ok(result);
        }
    }
}
