using StoreSystem.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.IBLL
{
   public interface IGoodsClass:IDisposable
   {
       Task<List<DtoClass>> GetAllClassList();

       

   }
}
