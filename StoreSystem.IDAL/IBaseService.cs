using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public  interface IBaseService<T> where  T:BaseModelUid,new()
    {
        Task InsertAsync(T model);


        Task UpdateAsync(T model);

        Task DeleteAsync(int id);

        Task SaveAsync();

        IQueryable<T> GetOneByIdAsync(int id);
        IQueryable<T> GetAllAsync();


    }
}
