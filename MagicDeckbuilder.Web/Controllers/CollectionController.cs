using Microsoft.AspNetCore.Mvc;

namespace MagicDeckbuilder.Controllers
{
    public class CollectionController : Controller
    {
        // GET
        public IActionResult Overview()
        {
            return View();
        }
    }
}