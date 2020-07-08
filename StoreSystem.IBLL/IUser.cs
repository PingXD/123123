using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.IBLL
{
    public   interface IUser:IDisposable
    {
        Task Registered(Dto.DtoUser du);
        
    }
}
