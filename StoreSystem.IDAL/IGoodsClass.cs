using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public interface IGoodsClass<T> where  T:GoodsClass
    {
        Task<T> GetGoodsClass();
    }
}
