using System.Web;
using System.Web.Mvc;

namespace Week2_DomainLayer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}