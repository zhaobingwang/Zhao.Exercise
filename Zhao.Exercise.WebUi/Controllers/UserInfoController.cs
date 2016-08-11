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
            UserInfoService bll = new UserInfoService();
            UserInfoList = bll.GetList();
            return View();
        }
    }
}