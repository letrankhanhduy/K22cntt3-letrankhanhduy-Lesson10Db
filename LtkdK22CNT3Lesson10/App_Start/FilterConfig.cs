using System.Web;
using System.Web.Mvc;

namespace LtkdK22CNT3Lesson10
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
