using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Course
    {
        //Ders bilgileri
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public string Course_Codes { get; set; }
        public int Credits { get; set; }
        public int Advisor_ID { get; set; }
        public string Department { get; set; }
        public bool IsMandatory { get; set; }
    }
}
