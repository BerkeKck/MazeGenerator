using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Abstract
{
    public interface ICategoryService
    {
        public Category? GetCategory(int id);
        public List<Category> GetCategoryList();

        public List<CategoryProducts> GetProducts(int id);


    }
}
