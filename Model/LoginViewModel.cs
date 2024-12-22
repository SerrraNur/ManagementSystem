using EntityLayer.Concrete;

namespace Core_ManagementSystem.Models
{
    public class LoginViewModel
    {
        public Login Login { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        public Student Student { get; set; }
        public Advisor Advisor { get; set; }
    }
}
