using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationReact.Models;

namespace WebApplicationReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tblCarPropsController : ControllerBase
    {
        private readonly CarDBContext _context;

        public tblCarPropsController(CarDBContext context)
        {
            _context = context;
        }

        // GET: api/tblCarProps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblCarProp>>> GettblCarProps()
        {
            return await _context.tblCarProps.ToListAsync();
        }

        // GET: api/tblCarProps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tblCarProp>> GettblCarProp(int id)
        {
            var tblCarProp = await _context.tblCarProps.FindAsync(id);

            if (tblCarProp == null)
            {
                return NotFound();
            }

            return tblCarProp;
        }

        // PUT: api/tblCarProps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PuttblCarProp(int id, tblCarProp tblCarProp)
        {
            if (id != tblCarProp.IdCar)
            {
                return BadRequest();
            }

            _context.Entry(tblCarProp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCarPropExists(id))
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

        // POST: api/tblCarProps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<tblCarProp>> PosttblCarProp(tblCarProp tblCarProp)
        {
            _context.tblCarProps.Add(tblCarProp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettblCarProp", new { id = tblCarProp.IdCar }, tblCarProp);
        }

        // DELETE: api/tblCarProps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<tblCarProp>> DeletetblCarProp(int id)
        {
            var tblCarProp = await _context.tblCarProps.FindAsync(id);
            if (tblCarProp == null)
            {
                return NotFound();
            }

            _context.tblCarProps.Remove(tblCarProp);
            await _context.SaveChangesAsync();

            return tblCarProp;
        }

        private bool tblCarPropExists(int id)
        {
            return _context.tblCarProps.Any(e => e.IdCar == id);
        }
    }
}
