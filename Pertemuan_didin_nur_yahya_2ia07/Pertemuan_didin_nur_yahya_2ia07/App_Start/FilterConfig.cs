using System.Web;
using System.Web.Mvc;

namespace Pertemuan_didin_nur_yahya_2ia07
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}