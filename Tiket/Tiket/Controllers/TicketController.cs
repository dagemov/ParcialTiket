using Microsoft.AspNetCore.Mvc;

namespace Tiket.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
