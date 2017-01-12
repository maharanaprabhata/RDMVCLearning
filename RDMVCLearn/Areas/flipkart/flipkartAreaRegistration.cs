using System.Web.Mvc;

namespace RDMVCLearn.Areas.flipkart
{
    public class flipkartAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "flipkart";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "flipkart_default",
                "flipkart/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}