using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CourseSelection
    {
        //Ders seçimi yapma kısmı
        public int Selection_ID { get; set; }
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public bool IsApproved { get; set; }//onaylandı-onaylanmadı
    }
}
