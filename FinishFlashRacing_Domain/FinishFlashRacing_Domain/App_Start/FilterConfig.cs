using System.Web;
using System.Web.Mvc;

namespace FinishFlashRacing_Domain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}