using MagicDeckbuilder.Logic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagicDeckbuilder.Controllers
{
    public class CollectionController : Controller
    {
        // GET
        public IActionResult Overview()
        {
            Card card = new Card();
            return View (card);
        }
    }
}