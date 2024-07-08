using KitapYorum.DAL.Abstract;
using KitapYorum.Entites.Concrete;
using KitapYorum.Entites.Contexts;
using KitapYorum.DAL.Concrete;
using Microsoft.AspNetCore.Identity;
namespace KtapYorum.TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext context = new AppDbContext();

           
            

            IRepository<AppDbContext, Kategori, int> repository = new Repository<AppDbContext, Kategori, int>(context);
            Kategori kategori1 = new Kategori()
            {
                KategoriAdi = "Tarih",
                MyUserId= "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori1);
            Kategori kategori2 = new Kategori()
            {
                KategoriAdi = "Edebiyat",
                MyUserId = "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori2);
            Kategori kategori3 = new Kategori()
            {
                KategoriAdi = "Felsefe",
                MyUserId = "690e9b81-2419-423f-bb41-e1d830e264c1"
            };
            await repository.AddAsync(kategori3);
            var kategoriler = await repository.GetAllAsync(null);

            foreach (var item in kategoriler)
            {
                Console.WriteLine(item.KategoriAdi);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
