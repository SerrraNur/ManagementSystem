using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    //GenericService dışardan bir T değeri alacak(entity)
    //her bir entity için bu kısım ayrı ayrı yapılabilir ama bu kolaylaştırıyor.
     public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T GetByID(int id);
    }
}
