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
    public class UserPackagesController : ControllerBase
    {
        private readonly CrmDbContext _context;

        public UserPackagesController(CrmDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPackage>>> GetUsersPackages()
        {
          if (_context.UsersPackages == null)
          {
              return NotFound();
          }
            return await _context.UsersPackages.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPackage>> GetUserPackage(int id)
        {
          if (_context.UsersPackages == null)
          {
              return NotFound();
          }
            var userPackage = await _context.UsersPackages.FindAsync(id);

            if (userPackage == null)
            {
                return NotFound();
            }

            return userPackage;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPackage(int id, UserPackage userPackage)
        {
            if (id != userPackage.UserPackageId)
            {
                return BadRequest();
            }

            _context.Entry(userPackage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPackageExists(id))
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
        public async Task<ActionResult<UserPackage>> PostUserPackage(UserPackage userPackage)
        {
          if (_context.UsersPackages == null)
          {
              return Problem("Entity set 'CrmDbContext.UsersPackages'  is null.");
          }
            _context.UsersPackages.Add(userPackage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserPackage", new { id = userPackage.UserPackageId }, userPackage);
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserPackage(int id)
        {
            if (_context.UsersPackages == null)
            {
                return NotFound();
            }
            var userPackage = await _context.UsersPackages.FindAsync(id);
            if (userPackage == null)
            {
                return NotFound();
            }

            _context.UsersPackages.Remove(userPackage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserPackageExists(int id)
        {
            return (_context.UsersPackages?.Any(e => e.UserPackageId == id)).GetValueOrDefault();
        }
    }
}
