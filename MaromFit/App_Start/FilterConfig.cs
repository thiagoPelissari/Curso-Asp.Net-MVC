using System.Web;
using System.Web.Mvc;

namespace MaromFit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthorizeAttribute());    //Verificar Autenticação em todo o sistema
            //filters.Add(new RequireHttpsAttribute()); //Habilitar SSL no site inteiro
        }
    }
}
