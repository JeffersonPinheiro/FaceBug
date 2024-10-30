using Microsoft.AspNetCore.Mvc;

namespace FaceBug.ProfileApi.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
