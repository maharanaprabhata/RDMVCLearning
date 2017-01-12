using System.Web.Mvc;

namespace RDMVCLearn.Areas.ebay
{
    public class ebayAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ebay";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ebay_default",
                "ebay/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}