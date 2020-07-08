using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.IDAL;
using StoreSystem.Model;

namespace StoreSystem.DAL
{
    public class User :BaseService<Model.User> ,IUser<Model.User>
    {
        

        public User():base(new StoreContext())
        {
            
        }
        public Task UserAuth(Model.User user)
        {
            throw new NotImplementedException();
        }
        public Task ChangeUserPwd(Model.User user)
        {
            throw new NotImplementedException();
        }

        public Task Registered(Model.User user, bool b)
        {
          return InsertAsync(user);
        }

        public new void Dispose()
        {

        }
    }
}
