using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StoreSystem.Model
{
  public  class User:BaseModelUid
  {
      /// <summary>
      /// 用户名
      /// </summary>
      public string UserName { get; set; }
      /// <summary>
      /// 密码
      /// </summary>
      public string PassWord { get; set; }
      /// <summary>
      /// 昵称
      /// </summary>
      public string NickName { get; set; }
      /// <summary>
      /// 手机号
      /// </summary>
      public string PhoneNum { get; set; }
  }
}
