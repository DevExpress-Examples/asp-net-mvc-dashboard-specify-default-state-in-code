Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace MvcDashboard_DefaultDashboardState
    Public Class CustomDashboardStateService
        Implements IDashboardStateService

        Public Function GetState(ByVal dashboardId As String, ByVal dashboard As XDocument) As DashboardState Implements IDashboardStateService.GetState
            Dim dashboardState As New DashboardState()

            Dim parameterState As New DashboardParameterState("countryParameter", "USA", GetType(String))

            Dim gridFilterState As New DashboardItemState("gridDashboardItem1")
            gridFilterState.MasterFilterValues.AddRange(New List(Of Object())() From {
                New String(0) {"Andrew Fuller"},
                New String(0) {"Laura Callahan"}
            })

            Dim treemapDrilldownState As New DashboardItemState("treemapDashboardItem1")
            treemapDrilldownState.DrillDownValues.Add("Beverages")

            Dim rangeFilterState As New DashboardItemState("rangeFilterDashboardItem1")
            rangeFilterState.RangeFilterState.Selection = New RangeFilterSelection(New Date(2015, 1, 1), New Date(2016, 1, 1))

            dashboardState.Parameters.Add(parameterState)
            dashboardState.Items.AddRange(New List(Of DashboardItemState)() From {gridFilterState, treemapDrilldownState, rangeFilterState})
            Return dashboardState
        End Function
    End Class
End Namespace