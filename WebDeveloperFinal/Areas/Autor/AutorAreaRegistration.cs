using System.Web.Mvc;

namespace WebDeveloperFinal.Areas.Autor
{
    public class AutorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Autor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Autor_default",
               "Intranet/{action}/{id}",
                new { controller = "Internal", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}