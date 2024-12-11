using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        //Kullanıcı girişii ve rollerin belirlenmesi
        public int User_ID { get; set; }
        [Required(ErrorMessage ="Kullanıcı adı gereklidir.")] public required string User_Name { get; set; }
        [Required(ErrorMessage = "Kullanıcı şifresi gereklidir.")] public required string PasswordHash { get; set; }
        public int Role_ID { get; set; }
    }
}
