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


    public class BaseService<T> : IBaseService<T> where T : BaseModelUid,new()
    {
        private StoreContext _db = new StoreContext( );


    public async Task DeleteAsync(int id)
        {
            
            var t = new T()
            {
                Uid = id
            };
            _db.Entry(t).State = EntityState.Unchanged;
            t.IsDelete = true;
            await _db.SaveChangesAsync();

        }

        public async Task DeleteAsync(T model)
        {
            await DeleteAsync(model.Uid);
        }



        public IQueryable<T> GetAllAsync()
        {
            
            return _db.Set<T>().AsNoTracking();
        }
        

        public IQueryable<T> GetOneByIdAsync(int id)
        {
           return _db.Set<T>().Where(m => m.Uid == id).AsNoTracking();

        }

        public async Task InsertAsync(T model)
        {
            _db.Set<T>().Add(model);
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T model)
        {
            _db.Entry(model).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
        public void Dispose()
        {
           _db.Dispose();
        }
    }
}
