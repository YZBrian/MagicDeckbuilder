using Microsoft.AspNetCore.Mvc;

namespace MagicDeckbuilder.Controllers
{
    public class CardController : Controller
    {
        // GET
        public IActionResult Overview()
        {
            return View();
        }
    }
}