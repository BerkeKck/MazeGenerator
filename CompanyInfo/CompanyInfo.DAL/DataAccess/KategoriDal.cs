using CompanyInfo.Entities.DbContexts;
using CompanyInfo.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.DAL.DataAccess
{
    public class KategoriDal
    {
        private AppDbContext _dbContext;
        public KategoriDal()
        {
            _dbContext = new AppDbContext();
        }
        public void Insert(Kategori input)
        {
            _dbContext.Kategoriler.Add(input);
            _dbContext.SaveChanges();
        }
        public void Update(Kategori input)
        {
            _dbContext.Kategoriler.Update(input);
            _dbContext.SaveChanges();
        }

        public void Delete(Kategori input)
        {
            _dbContext.Kategoriler.Remove(input);
            _dbContext.SaveChanges();
        }

        public Kategori? GetById(int id)
        {
            var Kategori = _dbContext.Kategoriler.Find(id);
            return Kategori;
        }
        public ICollection<Kategori> GetAll()
        {
            return _dbContext.Kategoriler.ToList();
        }
    }
}
