
using MeetingApp.Models;
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

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "ABC Kongre Merkezi",
                MeetingDate = new DateTime(2024, 01, 24, 10, 0, 0),
                ParticipantNumber = 10
            };


            return View(model: meetingInfo);
        }
    }
}