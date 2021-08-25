# Dashboard for MVC - How to specify a default dashboard state in code

The example shows how to specify a [dashboard state](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state) (such as master filter or parameter values) in code and how to apply this state when loading a dashboard for the first time. In this example, the [DashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState) object holds the required dashboard state. The [DashboardConfigurator.SetDashboardStateService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDashboardStateService(DevExpress.DashboardWeb.IDashboardStateService)) method call applies the specified dashboard state when loading a dashboard.

<!-- default file list -->
## Files to Look at

* [CustomDashboardStateService.cs](./CS/MvcDashboard_DefaultDashboardState/App_Start/CustomDashboardStateService.cs) (VB: [CustomDashboardStateService.vb](./VB/MvcDashboard_DefaultDashboardState/App_Start/CustomDashboardStateService.vb))
* [DashboardConfig.cs](./CS/MvcDashboard_DefaultDashboardState/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_DefaultDashboardState/App_Start/DashboardConfig.vb))
* [HomeController.cs](./CS/MvcDashboard_DefaultDashboardState/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_DefaultDashboardState/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_DefaultDashboardState/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_DefaultDashboardState/Global.asax.vb))
* [Index.cshtml](./CS/MvcDashboard_DefaultDashboardState/Views/Home/Index.cshtml)
<!-- default file list end -->

## More Examples

* [ASPxDashboard - How to specify a default dashboard state in code](https://github.com/DevExpress-Examples/aspxdashboard-how-to-specify-a-default-dashboard-state-in-code-t513681)
* [ASP.NET Core Dashboard Control - How to specify a default dashboard state in code](https://github.com/DevExpress-Examples/aspnet-core-dashboard-control-how-to-specify-a-default-dashboard-state-in-code-t607138)
* [WPF Dashboard - How to Set the Initial Dashboard State](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-set-initial-dashboard-state)
* [WinForms Dashboard - How to Save and Restore the Dashboard State](https://github.com/DevExpress-Examples/winforms-dashboard-save-restore-dashboard-state)


