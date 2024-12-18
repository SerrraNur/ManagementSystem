using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class AdvisorManager : IAdvisorService
    {
        IAdvisorDal _advisorDal;  //Atama işlemi için constructure metot ihtiyaç

        public AdvisorManager(IAdvisorDal advisorDal)
        {
            _advisorDal = advisorDal;
        }

        public Advisor GetByID(int id)
        {
            return _advisorDal.GetById(id);
        }

        public void TAdd(Advisor t)
        {
            _advisorDal.Insert(t);//IGenericDal kısmında tanımladığım metotlar
        }

        public void TDelete(Advisor t)
        {
            _advisorDal.Delete(t);
        }

        public List<Advisor> TGetList()
        {
           return _advisorDal.GetList();
        }

        public void TUpdate(Advisor t)
        {
            _advisorDal.Update(t);
        }
    }
}
