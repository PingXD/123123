using System;
using System.Threading.Tasks;
using StoreSystem.Model;
namespace IDAL
{
   public  interface IIndex<T> where T:StoreSystem.Model.IndexViewData
    {
        /// <summary>
        /// 异步获取主页数据
        /// </summary>
        /// <returns></returns>
        Task<T>  GetIndexData();

        

    }
}
