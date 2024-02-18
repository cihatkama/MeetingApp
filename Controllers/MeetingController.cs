using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]   // bir action metodunun HttpVerb tipi seçilmezse default olarak HttpGet olarak işaretlenir.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Email, string Phone, bool WillAttend)
        {
            // Model Binding aracılığı ile değerler arayüzden post edilir.
            Console.WriteLine(Name + " - " + Email + " - " + Phone + " - " + WillAttend.ToString());
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
