using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{
   public class Goods:BaseModelGuid
    {
        public string GoodsImage { get; set; }
        public string  GoodsName { get; set; }
        public double Price { get; set; }
        public GoodsClass GoodsClass { get; set; }

    }
}
