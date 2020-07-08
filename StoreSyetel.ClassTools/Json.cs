using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace StoreSystem.ClassTools
{
    public static class Json
    {
        public static List<T> JsonToModel<T>(string jsonStr)
        {
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<T>));
            jsonStr = "[" + jsonStr + "]";
            using (MemoryStream ms = new  MemoryStream(Encoding.UTF8.GetBytes(jsonStr)))
            {
              return (List<T>)dcjs.ReadObject(ms);
            }
        }
       
        
    }
}
