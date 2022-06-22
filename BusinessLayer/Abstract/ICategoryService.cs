using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Catergory category);
        void CategoryDelete(Catergory catergory);
        void CategoryUpdate(Catergory category);
        List<Catergory> GetList();
        Catergory GetById(int id);


    }
}
