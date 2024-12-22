using EntityLayer.Concrete;

namespace Core_ManagementSystem.Models
{
    public class LoginViewModel
    {
        public Login Login { get; set; }
        public User User_Name { get; set; }
        public Role Role_ID { get; set; }
        public Student Student { get; set; }
        public Advisor Advisor { get; set; }
        public string Password { get; set; }
    }
}

