using CompanyInfo.BL.Managers.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class _KategoriController : Controller
    {
        private readonly IKategoriManager kategoriManager;

        public _KategoriController(IKategoriManager kategoriManager)
        {
            this.kategoriManager = kategoriManager;
        }

        public async Task<IActionResult> Index()
        {
            var kategoriler = kategoriManager.GetAll();
            return View(kategoriler);
        }
    }
}
