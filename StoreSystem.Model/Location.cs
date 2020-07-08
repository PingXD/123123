using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreSystem.Model
{
   public class Location:BaseModelUid
    {
        //外键是User的主键
        /// <summary>
        /// 地址的外键，关联User主键
        /// </summary>
        [Required,ForeignKey("User")]
        public int UserId { get; set; }
        /// <summary>
        /// 地址详细信息
        /// </summary>
        public string LocationAddress { get; set; }
    }
}
