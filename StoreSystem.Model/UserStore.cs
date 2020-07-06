using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{
   public class UserStore:BaseModelUid
    {
        //userid是外键
        /// <summary>
        /// 购物车中的商品id数组
        /// </summary>
        public int Goods{get; set; }
        /// <summary>
        /// 关联的用户id
        /// </summary>
        public int UserId { get; set; }


    }
}
