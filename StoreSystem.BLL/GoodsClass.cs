using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Dto;
using StoreSystem.IBLL;
using StoreSystem.Model;
using System.Linq;
namespace StoreSystem.BLL
{
    public class GoodsClass : IGoodsClass
    {
        public Task<List<DtoClass>> GetAllClassList()
        {
            using (IDAL.IGoodsClass ic = new DAL.GoodsClass())
            {
                using (IDAL.IGoodsClassMaster icm = new DAL.GoodsClassMaster())
                {
                    var s = ic.GetGoodsClass();
                    var b = icm.GetAllGoodsClassMaster();
                    var t = from goodsClass in s
                            from goodsClassMaster in b
                            select new
                            {
                                    goodsClassMaster.ClassMater,
                                    goodsClass.GoodsClassBelong,
                            };
                    return (Task<List<DtoClass>>)t;

                }

            }

          
            
          
            
                    
            throw new NotImplementedException();
        }
    }
}
