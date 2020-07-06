using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public interface IIndexData<T> where T:IndexViewData
    {
        Task<T> GetImage();
        
    }
}
