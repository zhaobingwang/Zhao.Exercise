using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace Zhao.Exercise.WebUi.Areas.Lambda.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Lambda/Default
        public  ActionResult Index()
        {
            return View();
        }
    }
}