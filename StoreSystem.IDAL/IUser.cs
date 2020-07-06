using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public interface IUser<T> where T:User
    {
        Task<bool> UserAuth(T user);
        Task<bool> ChangeUserPwd(T user);
    }
}
