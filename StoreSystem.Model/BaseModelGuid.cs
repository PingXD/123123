using System;

namespace StoreSystem.Model
{
    public class BaseModelGuid
    {
        /// <summary>
        /// Guid的方式创建主键
        /// </summary>
        public Guid Guid { get; set; } = Guid.NewGuid();
        /// <summary>
        /// 创建的时间
        /// </summary>
        public DateTime DateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 伪删除
        /// </summary>
        public bool IsDelete { get; set; }

    }
}
