using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        Student IGenericService<Student>.GetByID(int id)
        {
            return _studentDal.GetById(id);
        }

        void IGenericService<Student>.TAdd(Student t)
        {
            _studentDal.Insert(t);
        }

        void IGenericService<Student>.TDelete(Student t)
        {
            _studentDal.Delete(t);
        }

        List<Student> IGenericService<Student>.TGetList()
        {
            return _studentDal.GetList();
        }

        void IGenericService<Student>.TUpdate(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
