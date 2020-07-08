using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace StoreSystem.MVC.Models
{
  public class VUser
  {
      /// <summary>
      /// 用户名
      /// </summary>
      [Required,StringLength(16)]
      public string UserName { get; set; }
      /// <summary>
      /// 密码
      /// </summary>
      [Required, StringLength(32)]
      public string PassWord { get; set; }
      /// <summary>
      /// email
      /// </summary>
      [EmailAddress]
      public string Email { get; set; }
      /// <summary>
      /// 手机号
      /// </summary>
     [Required,StringLength(11),Phone]
      public string PhoneNum { get; set; }
  }
}
