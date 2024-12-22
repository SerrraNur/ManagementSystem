using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_ManagementSystem.ViewComponents.Advisor
{
    public class AdvisorCourseSelectionList : ViewComponent
    {
        StudentManager studentManager = new StudentManager(new EFStudentDal());
        CourseManager courseManager = new CourseManager(new EFCourseDal());
        CourseSelectionManager courseSelectionManager = new CourseSelectionManager(new EFCourseSelectionDal());

        public IViewComponentResult Invoke()
        {
            var students = studentManager.TGetList();

            var viewModel = students.Select(student => new CourseSelectionViewModel
            {
                Student = student,
                SelectedCourses = courseSelectionManager.TGetList()
                    .Where(cs => cs.StudentId == student.Id)
                    .Select(cs => courseManager.TGetById(cs.CourseId))
                    .ToList()
            }).ToList();

            return View(viewModel);
        }
    }
}

//namespace Core_ManagementSystem.ViewComponents.CourseSelected
//{
//    public class CourseSelectedList:ViewComponent
//    {
//        CourseSelectionManager courseSelectionManager = new CourseSelectionManager(new EFCourseSelectionDal());
//        public IViewComponentResult Invoke()
//        {
//            var values = courseSelectionManager.TGetList();
//            return View(values);
//        }
//    }

}
