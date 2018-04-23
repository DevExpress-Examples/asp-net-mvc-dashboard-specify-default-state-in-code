using System.Web.Mvc;

namespace MvcDashboard_DefaultDashboardState {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}