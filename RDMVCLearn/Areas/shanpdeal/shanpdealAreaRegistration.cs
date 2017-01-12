using System.Web.Mvc;

namespace RDMVCLearn.Areas.shanpdeal
{
    public class shanpdealAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "shanpdeal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "shanpdeal_default",
                "shanpdeal/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}