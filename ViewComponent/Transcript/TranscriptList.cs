using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Core_ManagementSystem.Models;
using System.Linq;

namespace Core_ManagementSystem.ViewComponents.Transcript
{
    public class TranscriptList : ViewComponent
    {
        TranscriptManager transcriptManager = new TranscriptManager(new EFTranscriptDal());
        StudentManager studentManager = new StudentManager(new EFStudentDal());
        CourseManager courseManager = new CourseManager(new EFCourseDal());

        public IViewComponentResult Invoke()
        {
            
            var students = studentManager.TGetList();
            var transcripts = transcriptManager.TGetList();
            var courses = courseManager.TGetList();

            var viewModel = students.Select(student => new TranscriptViewModel
            {
                Student = student,
                CourseDetails = transcripts
                    .Where(t => t.StudentId == student.Id)
                    .Select(t => new TranscriptCourseDetail
                    {
                        CourseName = courses.FirstOrDefault(c => c.Id == t.CourseId)?.CourseName ?? "Unknown",
                        Credit = courses.FirstOrDefault(c => c.Id == t.CourseId)?.Credit ?? 0,
                        Grade = t.Grade
                    })
                    .ToList()
            }).ToList();

            return View(viewModel);
        }
    }
}


//namespace Core_ManagementSystem.ViewComponents.Transcript
//{
//    public class TranscriptList : ViewComponent
//    {
//        TranscriptManager transcriptManager = new TranscriptManager(new EFTranscriptDal());

//        public IViewComponentResult Invoke()
//        {
//            var values = transcriptManager.TGetList();
//            return View(values);
//        }
//    }
//}
