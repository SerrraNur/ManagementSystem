using EntityLayer.Concrete;

namespace Core_ManagementSystem.Models
{
    public class TranscriptViewModel
    {
        public Student Student { get; set; }
        public List<TranscriptCourseDetail> CourseDetails { get; set; }
    }

    public class TranscriptCourseDetail
    {
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public string Grade { get; set; }
    }
}
