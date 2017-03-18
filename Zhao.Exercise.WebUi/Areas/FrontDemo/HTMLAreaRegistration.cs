using System.Web.Mvc;

namespace Zhao.Exercise.WebUi.Areas.HTML
{
    public class HTMLAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HTML";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HTML_default",
                "HTML/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}