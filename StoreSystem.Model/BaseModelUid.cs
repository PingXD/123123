using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{ 
    public class BaseModelUid
    {
        public int Uid { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }
    }
}
