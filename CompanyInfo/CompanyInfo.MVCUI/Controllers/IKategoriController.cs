using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class KategoriController : Controller
    {
        private readonly IKategoriManager kategoriManager;


        public KategoriController(IKategoriManager urunManager, IKategoriManager KategoriManager)
        {
            this.kategoriManager = kategoriManager;
            KategoriManager = kategoriManager;
        }
    }
}