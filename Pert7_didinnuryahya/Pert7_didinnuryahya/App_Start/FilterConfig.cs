using System.Web;
using System.Web.Mvc;

namespace Pert7_didinnuryahya
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}