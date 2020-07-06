using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{
   public class GoodsClass:BaseModelUid
    {
        //外键是master的主键
        /// <summary>
        /// 商品二级分类名称
        /// </summary>
        public string GoodsClassBelong { get; set; }
        /// <summary>
        /// 商品一级分类名称
        /// </summary>
        public int ClassMasterId { get; set; }

    }
}
