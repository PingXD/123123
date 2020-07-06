using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{
   public class Goods:BaseModelUid
    {
        //外键是goodsclass的主键

        /// <summary>
        /// 商品主图路径
        /// </summary>
        public string GoodsImage { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string  GoodsName { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 商品分类的ID，是外键
        /// </summary>
        public int GoodsClassId { get; set; }

    }
}
