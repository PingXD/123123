using StoreSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   public interface IStore<T> where T: Goods
    {
        Task<T> GetGoodsOfClass(T GoodsClass);
    }
}
