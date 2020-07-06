using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreSystem.IDAL;
using StoreSystem.Model;

namespace StoreSystem.DAL
{
    public class GoodsClass<T>: IGoodsClass<T> where T: GoodsClass
    {
        private readonly DbContext _db;
        public Task<T> GetGoodsClass()
        {
            return (Task<T>)_db.Set<T>().Where(m => !m.IsDelete).AsNoTracking();
        }
    }
}
