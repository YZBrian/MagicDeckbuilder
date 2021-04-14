using MagicDeckbuilder.Logic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagicDeckbuilder.Controllers
{
    public class CardController : Controller
    {
        // GET
        public IActionResult Create()
        {
            Card card = new Card();
            return View(card);
        }
    }
}