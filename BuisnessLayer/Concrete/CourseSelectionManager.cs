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
    public class CourseSelectionManager : ICourseSelectionService
    {
        ICourseSelectionDal _courseSelectionDal;

        public CourseSelectionManager(ICourseSelectionDal courseSelectionDal)
        {
            _courseSelectionDal = courseSelectionDal;
        }

        CourseSelection IGenericService<CourseSelection>.GetByID(int id)
        {
            return _courseSelectionDal.GetById(id);
        }

        void IGenericService<CourseSelection>.TAdd(CourseSelection t)
        {
            _courseSelectionDal.Insert(t);
        }

        void IGenericService<CourseSelection>.TDelete(CourseSelection t)
        {
            _courseSelectionDal.Delete(t);
        }

        List<CourseSelection> IGenericService<CourseSelection>.TGetList()
        {
            return _courseSelectionDal.GetList();
        }

        void IGenericService<CourseSelection>.TUpdate(CourseSelection t)
        {
            _courseSelectionDal.Update(t);
        }
    }
}
