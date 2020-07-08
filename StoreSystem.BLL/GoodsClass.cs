using Microsoft.EntityFrameworkCore;
using StoreSystem.Dto;
using StoreSystem.IBLL;
using StoreSystem.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreSystem.BLL
{
    public class GoodsClass : IGoodsClass
    {
        
        public async Task<List<DtoClass>> GetAllClassList()
        {
            StoreContext dbContext = new StoreContext();
            IDAL.IGoodsClassMaster icm = new DAL.GoodsClassMaster(dbContext);
            var b = icm.GetAllGoodsClassMaster();



            IDAL.IGoodsClass ic = new DAL.GoodsClass(dbContext);
            
            var s = ic.GetGoodsClass();
           



                var t = from goodsClass in s
                        from goodsClassMaster in b
                        where goodsClassMaster.Uid == goodsClass.ClassMasterId
                        select new
                        {
                                goodsClassMaster.ClassMater,
                                goodsClass.GoodsClassBelong
                        };
               var t1 =  b.First();
                //var t2= s.First();
                return await (from st in t
                        select new DtoClass
                        {
                                ClassBelong = st.GoodsClassBelong,
                                ClassMaster = st.ClassMater
                        }).ToListAsync();

            



        }
        //public class MyClass
        //{
        //    public IQueryable<GoodsClassMaster> Te() {
        //     IDAL.IBaseService<GoodsClassMaster> ss=new DAL.BaseService<GoodsClassMaster>();
        //     return ss.GetOneByIdAsync(1);
                
        //    }
        //}



}

    
}
