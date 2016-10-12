using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zhao.Exercise.BLL;

namespace Zhao.Exercise.WebUi.Controllers
{
    public class UserInfoController : Controller
    {
        private List<Model.UserInfo> UserInfoList { get; set; }
        public ActionResult Index()
        {
            //UserInfoService bll = new UserInfoService();
            //UserInfoList = bll.GetList();
            return View();
        }
        public ActionResult List()
        {
            UserInfoService bll = new UserInfoService();
            UserInfoList = bll.GetList();
            return Json(UserInfoList);
        }
        public ActionResult Details()
        {
            string type = Request["type"];

            if (type=="show")
            {
                //获取数据
                string UserId = Request["row[UserId]"];
                string UserPwd = Request["row[UserPwd]"];
                int UserAge = int.Parse(Request["row[UserAge]"]);
                int DelFlag = int.Parse(Request["row[DelFlag]"]);
                DateTime CreateTime = Convert.ToDateTime(Request["row[CreateTime]"]);
                DateTime UpdateTime = Convert.ToDateTime(Request["row[UpdateTime]"]);

                ViewData["UserId"] = UserId;
                ViewData["UserPwd"] = UserPwd;
                ViewData["UserAge"] = UserAge;
                ViewData["DelFlag"] = DelFlag;
                ViewData["CreateTime"] = CreateTime;
                ViewData["UpdateTime"] = UpdateTime;

                
            }





            //UserInfoService bll = new UserInfoService();
            //bll.Update(UserInfo);

            return View();
        }
    }
}