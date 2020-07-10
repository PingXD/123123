using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreSystem.BLL;
using StoreSystem.MVC.Models;
using StoreSystem.ClassTools;
using System.Text;
using StoreSystem.Dto;

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
        public ActionResult ApiRegistered()
        {
            //try
            //{
            //    int dataLen = Convert.ToInt32(Request.Body.Length);
            //    byte[] bytes = new byte[dataLen];
            //    Request.Body.Read(bytes, 0, dataLen);
            //    //var m =ClassTools.Json.JsonToModel<Dto.DtoUser>(Encoding.UTF8.GetString(bytes)).FirstOrDefault();
            //    Request.Form[""]
            //    using (IBLL.IUser iu = new User())
            //    {
            //        iu.Registered(ClassTools.Json.JsonToModel<Dto.DtoUser>(Encoding.UTF8.GetString(bytes))
            //                .FirstOrDefault());
            //        string s = "断点";
            //    }

            //    return Ok("\"result\":success");
            ////}
            //catch
            //{
            //    return NotFound();
            //}

            using (IBLL.IUser iu = new User())
            {
                try
                {
                    VUser du = new VUser()
                    {
                           
                        //UserName = Request.Form["UserName"],
                        //PassWord = Request.Form["PassWord"],
                        //Email = Request.Form["Email"],
                        //PhoneNum = Request.Form["PhoneNum"]
                        PhoneNum ="155623687926511"
                    };
                    if (ModelState.IsValid)
                    {
                    }
                    //iu.Registered(du);
                    return Ok("\"result\":success");
                }
                catch
                {
                    return NotFound();
                }
                
            }
            
        }

        public ActionResult Registered()
        {

            return View();
        }

        public  ActionResult UserResult()
        {
            
            return View();
        }
    }
}
