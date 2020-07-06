using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{
   public class IndexViewData:BaseModelUid
    {
        /// <summary>
        /// 主页图片
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// 主页图片指向的Url
        /// </summary>
        public string ImageDirectionalUrl { get; set; }

    }
}
