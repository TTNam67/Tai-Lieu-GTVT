using Microsoft.AspNetCore.Mvc;

namespace OnlineClothingShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
