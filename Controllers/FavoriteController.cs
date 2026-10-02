using Microsoft.AspNetCore.Mvc;

namespace dz.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Games()
        {
            return View();
        }

        public IActionResult Movies()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }
    }
}
