using System.Web;
using System.Web.Mvc;

namespace ThiGKTrong_63135896
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
