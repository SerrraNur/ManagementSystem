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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        User IGenericService<User>.GetByID(int id)
        {
            return _userDal.GetById(id);
        }

        void IGenericService<User>.TAdd(User t)
        {
            _userDal.Insert(t);
        }

        void IGenericService<User>.TDelete(User t)
        {
            _userDal.Delete(t);
        }

        List<User> IGenericService<User>.TGetList()
        {
            return _userDal.GetList();
        }

        void IGenericService<User>.TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
