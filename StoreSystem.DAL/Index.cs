using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using StoreSystem.Model;
namespace StoreSystem.DAL
{
    public class Index<T> : IDAL.IIndex<T> where T:IndexViewData
    {
        public Task<T> GetIndexData()
        {
            throw new NotImplementedException();
        }

        
    }
}
