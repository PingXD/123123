using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StoreSystem.Model
{
  public  class User:BaseModelGuid
  {
      public string UserName { get; set; }
      public string PassWord { get; set; }
      public string NickName { get; set; }
  }
}
