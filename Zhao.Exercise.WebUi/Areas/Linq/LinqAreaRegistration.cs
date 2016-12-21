using System.Web.Mvc;

namespace Zhao.Exercise.WebUi.Areas.Linq
{
    public class LinqAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Linq";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Linq_default",
                "Linq/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}