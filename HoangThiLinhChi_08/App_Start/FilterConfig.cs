using System.Web;
using System.Web.Mvc;

namespace HoangThiLinhChi_08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
