using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class UrunController :Controller
    {
        private readonly IUrunManager urunManager;

        public UrunController(IUrunManager urunManager)
        {
            this.urunManager = urunManager;
        }

        public IActionResult Index()
        {
            var urunler = urunManager.GetAll();
            return View(urunler);
           
        }

        [ValidateAntiForgeryToken]
        [HttpPost]

        public IActionResult Create(UrunInsertVM insertVM)
        {
            //Gelen Model doğru gelmiş mi ?

            if (!ModelState.IsValid)
            {
                return View();
            }
             else
            {
                //Urun yeniUrun = new Urun();
                //{
                //    UrunKodu = InsertVM.UrunKodu,
                //    UrunAdi = InsertVM.UrunAdi,

                //};
                //urunManager.Insert(yeniUrun);
                //return RedirectToAction("Index");
            }


            //Kendi Yazdigimiz validation'larin oldugu Class'tan 
            //Instance aliyoruz ve bunu view'e gonderiyoruz
            
            //UrunInsertVM insertVM = new UrunInsertVM();

            return View();
        }
    }
}
