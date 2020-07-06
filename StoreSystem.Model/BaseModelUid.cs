﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{ 
    public class BaseModelUid
    {
        /// <summary>
        /// Uid的方式创建主键
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 创建当前时间
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 伪删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
