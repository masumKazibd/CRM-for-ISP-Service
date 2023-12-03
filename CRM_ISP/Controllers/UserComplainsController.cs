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
    public class UserComplainsController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public UserComplainsController(CrmDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserComplain>>> GetUserComplain()
        {
          if (_context.UserComplain == null)
          {
              return NotFound();
          }
            return await _context.UserComplain.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<UserComplain>> GetUserComplain(int id)
        {
          if (_context.UserComplain == null)
          {
              return NotFound();
          }
            var userComplain = await _context.UserComplain.FindAsync(id);

            if (userComplain == null)
            {
                return NotFound();
            }

            return userComplain;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserComplain(int id, UserComplain userComplain)
        {
            if (id != userComplain.UserComplainId)
            {
                return BadRequest();
            }

            _context.Entry(userComplain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserComplainExists(id))
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
        public async Task<ActionResult<UserComplain>> PostUserComplain(UserComplain userComplain)
        {
          if (_context.UserComplain == null)
          {
              return Problem("Entity set 'CrmDbContext.UserComplain'  is null.");
          }
            _context.UserComplain.Add(userComplain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserComplain", new { id = userComplain.UserComplainId }, userComplain);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserComplain(int id)
        {
            if (_context.UserComplain == null)
            {
                return NotFound();
            }
            var userComplain = await _context.UserComplain.FindAsync(id);
            if (userComplain == null)
            {
                return NotFound();
            }

            _context.UserComplain.Remove(userComplain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserComplainExists(int id)
        {
            return (_context.UserComplain?.Any(e => e.UserComplainId == id)).GetValueOrDefault();
        }
    }
}
