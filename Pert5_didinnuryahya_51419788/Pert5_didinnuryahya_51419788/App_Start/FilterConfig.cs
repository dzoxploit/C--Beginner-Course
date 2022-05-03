using System.Web;
using System.Web.Mvc;

namespace Pert5_didinnuryahya_51419788
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}