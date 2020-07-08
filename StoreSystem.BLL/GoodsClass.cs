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
            
            using (IDAL.IGoodsClassMaster icm = new DAL.GoodsClassMaster())
            {
                var b = icm.GetAllGoodsClassMaster();
                using (IDAL.IGoodsClass ic = new DAL.GoodsClass())
                {
                    var s = ic.GetGoodsClass();
                    return await (from goodsClass in s
                                  from goodsClassMaster in b
                                  where goodsClassMaster.Uid == goodsClass.ClassMasterId
                                  select new DtoClass
                                  {
                                      ClassMaster = goodsClassMaster.ClassMater,
                                      ClassBelong = goodsClass.GoodsClassBelong
                                  }).ToListAsync();
                }
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

       

}

    
}
