using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Zhao.Exercise.WebUi.Areas.Tools.Controllers
{
    public class XmlController : Controller
    {
        // GET: Tools/Xml
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateXML()
        {
            var json = new { Result = "ok", Status = 0 };
            //string json = "A:[{Result:'ok',Status:0}]";
            //JsonConvert
            //var result = Json(json);
            var result = new JavaScriptSerializer().Serialize(json);
            return Json(result);
        }
    }
}