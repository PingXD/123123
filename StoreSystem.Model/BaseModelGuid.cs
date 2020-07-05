using System;

namespace StoreSystem.Model
{
    public class BaseModelGuid
    {

        public Guid Guid { get; set; } = Guid.NewGuid();

        public DateTime DateTime { get; set; } = DateTime.Now;

        public bool IsDelete { get; set; }

    }
}
