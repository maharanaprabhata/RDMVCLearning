using System.Web.Mvc;

namespace RDMVCLearn.Areas.amazon
{
    public class amazonAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "amazon";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "amazon_default",
                "amazon/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}