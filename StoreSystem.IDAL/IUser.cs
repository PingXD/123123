using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public interface IUser<T>:IDisposable where T:User
    {
        Task Registered(T user,bool bl=true);
        Task UserAuth(T user);
        Task ChangeUserPwd(T user);
    }
}
