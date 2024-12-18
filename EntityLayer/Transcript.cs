using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    internal class Transcript
    {
        public int Transcript_ID { get; set; }
        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
    }
}
