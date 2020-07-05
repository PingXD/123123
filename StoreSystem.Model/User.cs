using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace StoreSystem.Model
{
  public  class User:BaseModelGuid
  {
      public string UsernName { get; set; }
      public string PassWord { get; set; }
      public string NickName
      { get; set; }
  }
}
