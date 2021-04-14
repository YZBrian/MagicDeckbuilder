using MagicDeckbuilder.Logic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagicDeckbuilder.Controllers
{
    public class CardController : Controller
    {
        // GET
        public IActionResult Create()
        {
            ViewData.Model = new Card();
            return View();
        }
    }
}