using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {
        //Temada öğrenci bilgileri
        public int Student_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int Advisor_ID { get; set; }
    }
}
