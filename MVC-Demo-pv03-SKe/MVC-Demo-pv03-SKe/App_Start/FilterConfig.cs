using System.Web;
using System.Web.Mvc;

namespace MVC_Demo_pv03_SKe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
