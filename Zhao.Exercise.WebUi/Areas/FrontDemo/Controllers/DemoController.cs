using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zhao.Exercise.WebUi.Areas.FrontDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: FrontDemo/Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FullScreen()
        {
            return View();
        }
    }
}