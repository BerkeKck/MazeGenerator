using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapYorum.Entites.Concrete
{
    public class MyUser:IdentityUser
    {
        public string TcNo { get; set; }
        public bool Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

        [NotMapped]
        public int Yas { get; set; } 
    }
}
