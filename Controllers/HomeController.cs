
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            // ViewBag kullanımı ile data aktarımı
            // ViewBag.Selamlama = saat < 12 ? "Günaydın" : "İyi Günler";
            // ViewBag.UserName = "Cihat";

            // ViewData kullanımı ile data aktarımı
            ViewData["Selamlama"] = saat < 12 ? "Günaydın" : "İyi Günler";
            ViewData["UserName"] = "Cihat";

            return View();
        }
    }
}