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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        Role IGenericService<Role>.GetByID(int id)
        {
            return _roleDal.GetById(id);
        }

        void IGenericService<Role>.TAdd(Role t)
        {
            _roleDal.Insert(t);
        }

        void IGenericService<Role>.TDelete(Role t)
        {
            _roleDal.Delete(t);
        }

        List<Role> IGenericService<Role>.TGetList()
        {
            return _roleDal.GetList();
        }

        void IGenericService<Role>.TUpdate(Role t)
        {
            _roleDal.Update(t);
        }
    }
}
