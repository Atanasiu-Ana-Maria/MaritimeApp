using Microsoft.AspNetCore.Mvc;
using MaritimeAPI.Data;
using MaritimeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MaritimeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShipsController : ControllerBase
    {
        private readonly MaritimeContext _context;

        public ShipsController(MaritimeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ship>>> GetShips()
        {
            return await _context.Ships.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Ship>> CreateShip(Ship ship)
        {
            _context.Ships.Add(ship);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetShips), new { id = ship.ShipId }, ship);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShip(int id, Ship ship)
        {
            if (id != ship.ShipId)
            {
                return BadRequest();
            }

            _context.Entry(ship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Ships.Any(e => e.ShipId == id))
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

        // DELETE: /ships/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShip(int id)
        {
            var ship = await _context.Ships.FindAsync(id);
            if (ship == null)
            {
                return NotFound();
            }

            _context.Ships.Remove(ship);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}