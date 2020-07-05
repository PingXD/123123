using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface StoreClass<T> where T:StoreSystem.Model.GoodsClass
    {
        Task<T> GetAllClass();

    }
}
