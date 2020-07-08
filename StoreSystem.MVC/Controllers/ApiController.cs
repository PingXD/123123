using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreSystem.BLL;
using StoreSystem.MVC.Models;
using StoreSystem.ClassTools;
using System.Text;

namespace StoreSystem.MVC.Controllers
{
    public class ApiController : Controller
    {
        //public HttpGetAttribute GetAllGoodsClass()
        //{
           
        //    using IBLL.IGoodsClass gc = new GoodsClass();
        //    var t = from s in gc.GetAllClassList().Result
        //            select new VClass
        //            { 
        //                ClassBelong = s.ClassBelong,
        //                ClassMaster = s.ClassMaster
        //            };
        //    t.
            

            
            
        //}
        [HttpPost]
        public IActionResult Registered()
        {
            try
            {
                int dataLen = Convert.ToInt32(Request.Body.Length);
                byte[] bytes = new byte[dataLen];
                Request.Body.Read(bytes, 0, dataLen);
                //var m =ClassTools.Json.JsonToModel<Dto.DtoUser>(Encoding.UTF8.GetString(bytes)).FirstOrDefault();
                using (IBLL.IUser iu = new User())
                {
                    iu.Registered(ClassTools.Json.JsonToModel<Dto.DtoUser>(Encoding.UTF8.GetString(bytes))
                            .FirstOrDefault());
                }

                return Ok("\"result\":success");
            }
            catch
            {
                return NotFound();
            }

        }

    }
}
