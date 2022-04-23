using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tiket.Data;
using Tiket.Data.Entities;
namespace Tiket.Controllers
{
    public class EntranceController : Controller
    {
        private readonly DataContext _context;
        public EntranceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Verificate(Ticket ticket, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ticket.WasUsed == false)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
            }
            else
            {
                Ticket ticket1 = await _context.Tickets
               .Include(t => t.DateTime)
               .Include(t1 => t1.document)
               .Include(t2 => t2.name)

               .FirstOrDefaultAsync(m => m.Id == id);
                return View(ticket1);
            }
            return RedirectToAction(nameof(Index));


            // return View();
        }

    }
}
