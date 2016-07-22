using System.Web.Mvc;

namespace Zhao.Exercise.WebUi.Areas.CSharpBasisEx
{
    public class CSharpBasisExAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CSharpBasisEx";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CSharpBasisEx_default",
                "CSharpBasisEx/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}