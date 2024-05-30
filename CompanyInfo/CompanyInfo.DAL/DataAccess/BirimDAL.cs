using CompanyInfo.Entities.DbContexts;
using CompanyInfo.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfo.DAL.DataAccess
{
    public class BirimDAL
    {
        private AppDbContext _dbContext;
        public BirimDAL()
        {
            _dbContext= new AppDbContext();
        }
        public void Insert(Birim input)
        {
            _dbContext.Birimler.Add(input);
            _dbContext.SaveChanges();
        }
        public void Update(Birim input) 
        { 
            _dbContext.Birimler.Update(input);
            _dbContext.SaveChanges();
        }

        public void Delete(Birim input)
        {
            _dbContext.Birimler.Remove(input);
            _dbContext.SaveChanges();
        }

        public Birim? GetById(int id)
        {
            var birim = _dbContext.Birimler.Find(id);
            return birim;
        }
        public ICollection<Birim> GetAll()
        {
            return _dbContext.Birimler.ToList();
        }
    }
}
