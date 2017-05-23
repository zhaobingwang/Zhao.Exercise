using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zhao.Exercise.WebUi.Areas.FrontDemo.Controllers
{
    public class FrontController : Controller
    {
        // GET: FrontDemo/Front
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FullScreen()
        {
            int i =0;
            return View();
        }
    }
}