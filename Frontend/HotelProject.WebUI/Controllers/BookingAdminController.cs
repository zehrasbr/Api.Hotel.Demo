using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
