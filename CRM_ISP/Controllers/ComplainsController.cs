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
    public class ComplainsController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public ComplainsController(CrmDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complain>>> GetComplaines()
        {
          if (_context.Complaines == null)
          {
              return NotFound();
          }
            return await _context.Complaines.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Complain>> GetComplain(int id)
        {
          if (_context.Complaines == null)
          {
              return NotFound();
          }
            var complain = await _context.Complaines.FindAsync(id);

            if (complain == null)
            {
                return NotFound();
            }

            return complain;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplain(int id, Complain complain)
        {
            if (id != complain.ComplainId)
            {
                return BadRequest();
            }

            _context.Entry(complain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplainExists(id))
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
        public async Task<ActionResult<Complain>> PostComplain(Complain complain)
        {
          if (_context.Complaines == null)
          {
              return Problem("Entity set 'CrmDbContext.Complaines'  is null.");
          }
            _context.Complaines.Add(complain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplain", new { id = complain.ComplainId }, complain);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplain(int id)
        {
            if (_context.Complaines == null)
            {
                return NotFound();
            }
            var complain = await _context.Complaines.FindAsync(id);
            if (complain == null)
            {
                return NotFound();
            }

            _context.Complaines.Remove(complain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplainExists(int id)
        {
            return (_context.Complaines?.Any(e => e.ComplainId == id)).GetValueOrDefault();
        }
    }
}
