using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IdentityCoreDemo.Models;

namespace IdentityCoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTicketsController : ControllerBase
    {
        private readonly MyDbContext _context;

        public BookTicketsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/BookTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookTicket>>> GetBookTicket()
        {
            return await _context.BookTicket.ToListAsync();
        }

        // GET: api/BookTickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookTicket>> GetBookTicket(int id)
        {
            var bookTicket = await _context.BookTicket.FindAsync(id);

            if (bookTicket == null)
            {
                return NotFound();
            }

            return bookTicket;
        }

        // PUT: api/BookTickets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookTicket(int id, BookTicket bookTicket)
        {
            if (id != bookTicket.BookId)
            {
                return BadRequest();
            }

            _context.Entry(bookTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookTicketExists(id))
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

        // POST: api/BookTickets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BookTicket>> PostBookTicket(BookTicket bookTicket)
        {
            _context.BookTicket.Add(bookTicket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookTicket", new { id = bookTicket.BookId }, bookTicket);
        }

        // DELETE: api/BookTickets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BookTicket>> DeleteBookTicket(int id)
        {
            var bookTicket = await _context.BookTicket.FindAsync(id);
            if (bookTicket == null)
            {
                return NotFound();
            }

            _context.BookTicket.Remove(bookTicket);
            await _context.SaveChangesAsync();

            return bookTicket;
        }

        private bool BookTicketExists(int id)
        {
            return _context.BookTicket.Any(e => e.BookId == id);
        }
    }
}
