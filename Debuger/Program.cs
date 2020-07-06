using System;
using System.Linq;
using StoreSystem.Model;

namespace Debuger
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StoreSystem.IDAL.IGoodsClass ic = new StoreSystem.DAL.GoodsClass())
            {
                using (StoreSystem.IDAL.IGoodsClassMaster icm = new StoreSystem.DAL.GoodsClassMaster())
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
                    foreach (var a in t)
                    {
                        Console.WriteLine(a.ClassMater);
                        Console.WriteLine(a.GoodsClassBelong);
                    }
                }

            }
        }
    }
}
