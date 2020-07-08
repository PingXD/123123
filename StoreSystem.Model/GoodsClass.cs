using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreSystem.Model
{
   public class GoodsClass:BaseModelUid
    {
        //外键是master的主键
        /// <summary>
        /// 商品二级分类名称
        /// </summary>
        [Required,StringLength(10)]
        public string GoodsClassBelong { get; set; }
        /// <summary>
        /// 商品一级分类名称
        /// </summary>
        [Required,ForeignKey("GoodsClassMaster")]
        public int ClassMasterId { get; set; }

    }
}
