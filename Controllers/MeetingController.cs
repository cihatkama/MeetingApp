using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]   // bir action metodunun HttpVerb tipi seçilmezse default olarak HttpGet olarak işaretlenir.
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            // Model Binding aracılığı ile değerler arayüzden post edilir.
            // Console.WriteLine(model.Name + " - " + model.Email + " - " + model.Phone + " - " + model.WillAttend.ToString());

            // Veri tabanı aksiyonları yönetimi burada yapılabilir. DB işlemleri yapılana kadar statik liste ile ile çalışılacak.
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(m => m.WillAttend == true).Count();
            return View("Thanks", model);
        }

        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }
    }
}
