using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Firma.FirmaEntities.Abstract
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
