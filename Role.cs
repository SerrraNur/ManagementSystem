using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        //akademisyen ve öğrencilerin bilgi ve görevlerinin açıklamaları
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }
        public string Description { get; set; }
    }
}
