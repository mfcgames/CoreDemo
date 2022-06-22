using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Catergory catergory)
        {
            c.Add(catergory);
            c.SaveChanges();
        }

        public void DeleteCategory(Catergory catergory)
        {
            c.Remove(catergory);
            c.SaveChanges();
        }

        public Catergory GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Catergory> ListAllCategory()
        {
            return c.Categories.ToList();    
        }

        public void UpdateCategory(Catergory catergory)
        {
            c.Update(catergory);
            c.SaveChanges();
        }
    }
}
