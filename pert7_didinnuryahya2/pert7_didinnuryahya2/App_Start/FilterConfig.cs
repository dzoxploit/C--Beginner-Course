using System.Web;
using System.Web.Mvc;

namespace pert7_didinnuryahya2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}