using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreSystem.IBLL;
using StoreSystem.Dto;
using StoreSystem.Model;
namespace StoreSystem.BLL
{
    public class User : IUser
    {

        public async Task Registered(Dto.DtoUser du)
        {
            Model.User mUser= new Model.User()
            {
                UserName = du.UserName,
                PassWord = du.PassWord,
                NickName = du.NickName,
                PhoneNum = du.PhoneNum
            };
            using StoreContext dbContext = new StoreContext();
            using (IDAL.IUser<Model.User> iu = new DAL.User(dbContext))
            {
                await iu.Registered(mUser);
            }
        }
        public void Dispose()
        {

        }

    }
}
