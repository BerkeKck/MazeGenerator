using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.BL.Managers.Concrete
{
    public class UrunManager : ManagerBase<Urun>, IUrunManager
    {
        public ICollection<Urun> KritikStokSeviyesiAltindakiler()
        {
           
            return base.GetAll(p=>p.Adet<10);
        }
    }
}
