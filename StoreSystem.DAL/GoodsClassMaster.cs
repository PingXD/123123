using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.IDAL;
using StoreSystem.Model;
using Microsoft.EntityFrameworkCore;
namespace StoreSystem.DAL
{
    public class GoodsClassMaster : BaseService<Model.GoodsClassMaster>, IGoodsClassMaster
    {
        public GoodsClassMaster(StoreContext db):base(db)
        {
        }

        public IQueryable<Model.GoodsClassMaster> GetAllGoodsClassMaster()
        {
           return GetAllAsync();
        }


    }
}
