using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Dto;
using StoreSystem.IBLL;
using StoreSystem.Model;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace StoreSystem.BLL
{
    public class GoodsClass : IGoodsClass
    {
        public async Task<List<DtoClass>> GetAllClassList()
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
                                    goodsClass.GoodsClassBelong
                            };
                  return  await (from st in t
                            select new DtoClass
                            {
                                    ClassBelong = st.GoodsClassBelong,
                                    ClassMaster = st.ClassMater
                            }).ToListAsync();
                }
            }

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
