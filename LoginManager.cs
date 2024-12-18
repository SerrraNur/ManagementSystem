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
    public class LoginManager : IGenericService<Login>
    {
        ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        Login IGenericService<Login>.GetByID(int id)
        {
            return _loginDal.GetById(id);
        }

        void IGenericService<Login>.TAdd(Login t)
        {
            _loginDal.Insert(t);
        }

        void IGenericService<Login>.TDelete(Login t)
        {
            _loginDal.Delete(t);
        }

        List<Login> IGenericService<Login>.TGetList()
        {
            return _loginDal.GetList();
        }

        void IGenericService<Login>.TUpdate(Login t)
        {
            _loginDal.Update(t);
        }
    }
}
