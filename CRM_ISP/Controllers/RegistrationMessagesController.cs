using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM_ISP.Models;

namespace CRM_ISP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationMessagesController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public RegistrationMessagesController(CrmDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrationMessage>>> GetRegistrationMessages()
        {
          if (_context.RegistrationMessages == null)
          {
              return NotFound();
          }
            return await _context.RegistrationMessages.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistrationMessage>> GetRegistrationMessage(int id)
        {
          if (_context.RegistrationMessages == null)
          {
              return NotFound();
          }
            var registrationMessage = await _context.RegistrationMessages.FindAsync(id);

            if (registrationMessage == null)
            {
                return NotFound();
            }

            return registrationMessage;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistrationMessage(int id, RegistrationMessage registrationMessage)
        {
            if (id != registrationMessage.RegistrationMessageId)
            {
                return BadRequest();
            }

            _context.Entry(registrationMessage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistrationMessageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        
        [HttpPost]
        public async Task<ActionResult<RegistrationMessage>> PostRegistrationMessage(RegistrationMessage registrationMessage)
        {
          if (_context.RegistrationMessages == null)
          {
              return Problem("Entity set 'CrmDbContext.RegistrationMessages'  is null.");
          }
            _context.RegistrationMessages.Add(registrationMessage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegistrationMessage", new { id = registrationMessage.RegistrationMessageId }, registrationMessage);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistrationMessage(int id)
        {
            if (_context.RegistrationMessages == null)
            {
                return NotFound();
            }
            var registrationMessage = await _context.RegistrationMessages.FindAsync(id);
            if (registrationMessage == null)
            {
                return NotFound();
            }

            _context.RegistrationMessages.Remove(registrationMessage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegistrationMessageExists(int id)
        {
            return (_context.RegistrationMessages?.Any(e => e.RegistrationMessageId == id)).GetValueOrDefault();
        }
    }
}
