using EntityLayer.Concrete;

namespace Core_ManagementSystem.Models
{
    public class CourseSelectionViewModel
    {
        public Student Student { get; set; }
        public List<Course> SelectedCourses { get; set; }
    }
}
