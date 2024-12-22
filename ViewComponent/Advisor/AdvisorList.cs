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
    public class AdvisorList : ViewComponent
    {
        AdvisorManager advisorManager = new AdvisorManager(new EFAdvisorDal());
        StudentManager studentManager = new StudentManager(new EFStudentDal());
        CourseManager courseManager = new CourseManager(new EFCourseDal());

        public IViewComponentResult Invoke()
        {
            // Verileri çek
            var advisors = advisorManager.TGetList();
            var students = studentManager.TGetList();
            var courses = courseManager.TGetList();

           
            var viewModel = advisors.Select(advisor => new AdvisorViewModel
            {
                Advisor = advisor,
                Students = students, 
                Courses = courses    
            }).ToList();

            return View(viewModel); 
        }
    }
}

//namespace Core_ManagementSystem.ViewComponents.Advisor
//{
//    public class AdvisorList:ViewComponent
//    {
//        AdvisorManager advisorManager = new AdvisorManager(new EFAdvisorDal());
//        public IViewComponentResult Invoke()
//        {
//            var values = advisorManager.TGetList();
//            return View(values);
//        }
//    }
//}
