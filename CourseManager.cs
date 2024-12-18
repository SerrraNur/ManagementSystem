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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        Course IGenericService<Course>.GetByID(int id)
        {
            return _courseDal.GetById(id);
        }

        void IGenericService<Course>.TAdd(Course t)
        {
            _courseDal.Insert(t);
        }

        void IGenericService<Course>.TDelete(Course t)
        {
            _courseDal.Delete(t);
        }

        List<Course> IGenericService<Course>.TGetList()
        {
            return _courseDal.GetList();
        }

        void IGenericService<Course>.TUpdate(Course t)
        {
            _courseDal.Update(t);
        }
    }
}
