using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShelfApi.Models;

namespace BookShelfApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookShelfController : ControllerBase
    {

        private readonly BookContext _context;
        public BookShelfController(BookContext context)
        {
            _context = context;
            if (_context.Books.Count() == 0)
            {
                // Create a new Book if collection is empty,
                // which means you can't delete all Books.
                _context.Books.Add(new Book { title = "title1", author = "author1", isbn = "AGD52376453", loaned = false });
                _context.SaveChanges();
            }

        }

        // GET: api/BookShelf
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetTodoItems()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/BookShelf/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetTodoItem(long id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }


        // POST: api/BookShelf
        [HttpPost]
        public async Task<ActionResult<Book>> PostTodoItem(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = book.Id }, book);
        }

        // PUT: api/BookShelf/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/BookShelf/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.Books.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Books.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
