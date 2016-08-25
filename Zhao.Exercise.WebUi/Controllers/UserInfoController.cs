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
        public ActionResult Edit()
        {
            //获取数据
            string UserId=Request["row[UserId]"];
            string UserPwd = Request["row[UserPwd]"];
            int UserAge = int.Parse(Request["row[UserAge]"]);
            int DelFlag = int.Parse(Request["row[DelFlag]"]);
            DateTime CreateTime = Convert.ToDateTime(Request["row[CreateTime]"]);
            DateTime UpdateTime = Convert.ToDateTime(Request["row[UpdateTime]"]);

            Model.UserInfo UserInfo;


            UserInfoService bll = new UserInfoService();
            //bll.Update(UserInfo);

            return Content("ok");
        }
    }
}