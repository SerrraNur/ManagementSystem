using EntityLayer.Concrete;

namespace Core_ManagementSystem.Models
{
    public class AdvisorViewModel
    {
        public Advisor Advisor { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}
