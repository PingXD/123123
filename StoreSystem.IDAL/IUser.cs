using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using StoreSystem.Model;
namespace IDAL
{
   public interface User
    {
        Task<bool> UserAuth(StoreSystem.Model.User user);
        Task<bool> ChangeUserPassword(StoreSystem.Model.User user);

    }
}
