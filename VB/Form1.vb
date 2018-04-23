Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports System.Collections

Namespace KPIWithoutOLAP
	Partial Public Class Form1
		Inherits Form
		Private statusGraphic As PivotKPIGraphic = PivotKPIGraphic.Cylinder, trendGraphic As PivotKPIGraphic = PivotKPIGraphic.StatusArrow

		Public Sub New()
			InitializeComponent()

			Dim r As New Random()

			Dim table As New DataTable()
			table.Columns.Add("Year", GetType(Integer))
			table.Columns.Add("GrossRevenue", GetType(Integer))
			table.Columns.Add("GrossRevenueGoal", GetType(Integer))
			table.Rows.Add(2005, r.Next(10000000), r.Next(10000000))
			table.Rows.Add(2006, r.Next(10000000), r.Next(10000000))
			table.Rows.Add(2007, r.Next(10000000), r.Next(10000000))
			pivotGridControl1.DataSource = table
		End Sub

		Private Sub pivotGridControl1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As CustomFieldDataEventArgs) Handles pivotGridControl1.CustomUnboundFieldData
			e.Value = 0 ' we have two fake columns: Status and Trend
		End Sub

		Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs) Handles pivotGridControl1.CustomDrawCell
			If e.DataField IsNot fieldStatus AndAlso e.DataField IsNot fieldTrend Then
				Return
			End If
			Dim bitmap As Bitmap = Nothing
			If e.DataField Is fieldStatus Then
				bitmap = pivotGridControl1.GetKPIBitmap(statusGraphic, GetStatusValue(e))
			Else
				bitmap = pivotGridControl1.GetKPIBitmap(trendGraphic, GetTrendValue(e))
			End If
			e.Graphics.FillRectangle(New SolidBrush(e.Appearance.BackColor), e.Bounds)
			e.Graphics.DrawImage(bitmap, CInt(e.Bounds.Left + (e.Bounds.Width - bitmap.Width) / 2), CInt(e.Bounds.Top + (e.Bounds.Height - bitmap.Height) / 2))
			e.Handled = True
		End Sub

		Private Function GetStatusValue(ByVal e As PivotCustomDrawCellEventArgs) As Integer
			Dim revenue As Integer = Convert.ToInt32(pivotGridControl1.Cells.GetCellInfo(0, e.RowIndex).Value), goal As Integer = Convert.ToInt32(pivotGridControl1.Cells.GetCellInfo(1, e.RowIndex).Value)
			Return Comparer.Default.Compare(revenue, goal)
		End Function

		Private Function GetTrendValue(ByVal e As PivotCustomDrawCellEventArgs) As Integer
			If e.RowIndex = 0 Then
				Return 0
			End If
			Dim prevYearRevenue As Object = pivotGridControl1.Cells.GetCellInfo(0, e.RowIndex - 1).Value, thisYearRevenue As Object = pivotGridControl1.Cells.GetCellInfo(0, e.RowIndex).Value
			Return Comparer.Default.Compare(thisYearRevenue, prevYearRevenue)
		End Function
	End Class

	Public Class PivotGridControlEx
		Inherits PivotGridControl
		Public Function GetKPIBitmap(ByVal graphic As DevExpress.XtraPivotGrid.PivotKPIGraphic, ByVal state As Integer) As Bitmap
			Return Data.GetKPIBitmap(graphic, state)
		End Function
	End Class
End Namespace