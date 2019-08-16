using System.Web;
using System.Web.Mvc;

namespace DP_60321_TROSHKO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
