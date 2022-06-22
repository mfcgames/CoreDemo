using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;
        public CategoryManager()
        {
            _efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Catergory category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Catergory catergory)
        {
            _efCategoryRepository.Delete(catergory);
        }

        public void CategoryUpdate(Catergory category)
        {
            _efCategoryRepository.Update(category);
        }

        public Catergory GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }

        public List<Catergory> GetList()
        {
            return _efCategoryRepository.GetListAll();
        }
    }
}
