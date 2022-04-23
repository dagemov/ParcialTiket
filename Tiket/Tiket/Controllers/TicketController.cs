using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tiket.Data;
using Tiket.Data.Entities;

namespace Tiket.Controllers
{
    public class TicketController : Controller
    {
        private readonly DataContext _context;
        public TicketController(DataContext context)
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
        /*
        public async Task<IActionResult> Verificate(Ticket ticket, int? id)
        {
            if (ModelState.IsValid)
            {
                try
                {              
                    if(ticket.WasUsed==false)
                    {
                        _context.Add(ticket);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        Ticket ticket1= await _context.Tickets
                       .Include(t => t.DateTime)
                       .Include(t1 => t1.document)
                       .Include(t2=> t2.name)
                       
                       .FirstOrDefaultAsync(m => m.Id == id);       
                        return View(ticket1);
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un tikete con el mismo id");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
        }*/
    }
}
