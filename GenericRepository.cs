using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        void IGenericDal<T>.Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);        //t dn gelen değeri silme işlemi tamamlandı
            c.SaveChanges();    //Veri tabanına yansıtması için değişiklikleri kaydet
        }

        T IGenericDal<T>.GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        List<T> IGenericDal<T>.GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        void IGenericDal<T>.Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        void IGenericDal<T>.Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
