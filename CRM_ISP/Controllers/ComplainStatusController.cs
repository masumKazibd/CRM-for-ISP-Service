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
    public class ComplainStatusController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public ComplainStatusController(CrmDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComplainStatus>>> GetComplainesStatuses()
        {
          if (_context.ComplainesStatuses == null)
          {
              return NotFound();
          }
            return await _context.ComplainesStatuses.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ComplainStatus>> GetComplainStatus(int id)
        {
          if (_context.ComplainesStatuses == null)
          {
              return NotFound();
          }
            var complainStatus = await _context.ComplainesStatuses.FindAsync(id);

            if (complainStatus == null)
            {
                return NotFound();
            }

            return complainStatus;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplainStatus(int id, ComplainStatus complainStatus)
        {
            if (id != complainStatus.ComplainStatusId)
            {
                return BadRequest();
            }

            _context.Entry(complainStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplainStatusExists(id))
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
        public async Task<ActionResult<ComplainStatus>> PostComplainStatus(ComplainStatus complainStatus)
        {
          if (_context.ComplainesStatuses == null)
          {
              return Problem("Entity set 'CrmDbContext.ComplainesStatuses'  is null.");
          }
            _context.ComplainesStatuses.Add(complainStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplainStatus", new { id = complainStatus.ComplainStatusId }, complainStatus);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplainStatus(int id)
        {
            if (_context.ComplainesStatuses == null)
            {
                return NotFound();
            }
            var complainStatus = await _context.ComplainesStatuses.FindAsync(id);
            if (complainStatus == null)
            {
                return NotFound();
            }

            _context.ComplainesStatuses.Remove(complainStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplainStatusExists(int id)
        {
            return (_context.ComplainesStatuses?.Any(e => e.ComplainStatusId == id)).GetValueOrDefault();
        }
    }
}
