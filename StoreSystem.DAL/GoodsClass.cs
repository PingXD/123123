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
    public class GoodsClass : BaseService<Model.GoodsClass>, IGoodsClass
    {
        public GoodsClass() : base(new StoreContext())
        {
        }


        public IQueryable<Model.GoodsClass> GetGoodsClass()
        {
            return GetAllAsync();
        }

    }
}
