using System.Web;
using System.Web.Mvc;

namespace COMONUEVO_DataWarehouse
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
