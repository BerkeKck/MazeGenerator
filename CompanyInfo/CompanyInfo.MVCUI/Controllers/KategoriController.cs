using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriManager kategoriManager;

        public KategoriController(IKategoriManager kategoriManager)
        {
            this.kategoriManager = kategoriManager;
        }

        public async Task<IActionResult> Index()
        {
            var kategoriler = kategoriManager.GetAll();
            return View(kategoriler);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Bu class da tanimlamis oldugumuz Data Annotation 'larin calismasi icin instance alinmasi gerekir.
            KategoriInsertVM insertVM = new KategoriInsertVM();

            return View(insertVM);

        }

        [HttpPost]
        public IActionResult Create(KategoriInsertVM insertVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {

                int sonuc = 0;
                Kategori kategori = new()
                {
                    KategoriAdi=insertVM.KategoriAdi,
                    Aciklama=insertVM.Aciklama
                };
                try
                {
                     sonuc = kategoriManager.Insert(kategori);
                
                }
                catch (Exception ex)
                {
                    string errorMesaj = "";
                    if (ex.InnerException.ToString().Contains("duplicate"))
                    {
                        errorMesaj = "Bu kategori daha onceden tanimlanmistir";
                    }
                    else
                    {
                        errorMesaj = "Beklenmedik bir hata  olustu:";
                    }
                    ModelState.AddModelError("", errorMesaj);
                    return View();
                }
               
                if (sonuc > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Beklenmedik bir hata olustu.");
                    return View();
                }
            }
        }
    }
}
