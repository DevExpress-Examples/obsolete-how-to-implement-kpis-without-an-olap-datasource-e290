Imports Microsoft.VisualBasic
Imports System
Namespace KPIWithoutOLAP
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New KPIWithoutOLAP.PivotGridControlEx()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldStatus = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldTrend = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3, Me.fieldStatus, Me.fieldTrend})
			Me.pivotGridControl1.Location = New System.Drawing.Point(13, 13)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(750, 440)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomDrawCell += New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(Me.pivotGridControl1_CustomDrawCell);
'			Me.pivotGridControl1.CustomUnboundFieldData += New DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(Me.pivotGridControl1_CustomUnboundFieldData);
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField1.AreaIndex = 0
			Me.pivotGridField1.Caption = "Year"
			Me.pivotGridField1.FieldName = "Year"
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.Width = 200
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField2.AreaIndex = 0
			Me.pivotGridField2.Caption = "Gross Revenue"
			Me.pivotGridField2.CellFormat.FormatString = "c"
			Me.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.pivotGridField2.FieldName = "GrossRevenue"
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField3.AreaIndex = 1
			Me.pivotGridField3.Caption = "Goal"
			Me.pivotGridField3.CellFormat.FormatString = "c"
			Me.pivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.pivotGridField3.FieldName = "GrossRevenueGoal"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' fieldStatus
			' 
			Me.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldStatus.AreaIndex = 2
			Me.fieldStatus.Caption = "Status"
			Me.fieldStatus.Name = "fieldStatus"
			Me.fieldStatus.UnboundFieldName = "Status"
			Me.fieldStatus.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			' 
			' fieldTrend
			' 
			Me.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldTrend.AreaIndex = 3
			Me.fieldTrend.Caption = "Trend"
			Me.fieldTrend.Name = "fieldTrend"
			Me.fieldTrend.UnboundFieldName = "Trend"
			Me.fieldTrend.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(775, 465)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As PivotGridControlEx
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldStatus As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldTrend As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

