using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.WebMvc.Controllers
{
    public class BirimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
