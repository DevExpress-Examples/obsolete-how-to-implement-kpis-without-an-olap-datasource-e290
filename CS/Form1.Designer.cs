namespace KPIWithoutOLAP {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pivotGridControl1 = new KPIWithoutOLAP.PivotGridControlEx();
			this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldStatus = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTrend = new DevExpress.XtraPivotGrid.PivotGridField();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.fieldStatus,
            this.fieldTrend});
			this.pivotGridControl1.Location = new System.Drawing.Point(13, 13);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(750, 440);
			this.pivotGridControl1.TabIndex = 0;
			this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
			this.pivotGridControl1.CustomUnboundFieldData += new DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(this.pivotGridControl1_CustomUnboundFieldData);
			// 
			// pivotGridField1
			// 
			this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.pivotGridField1.AreaIndex = 0;
			this.pivotGridField1.Caption = "Year";
			this.pivotGridField1.FieldName = "Year";
			this.pivotGridField1.Name = "pivotGridField1";
			this.pivotGridField1.Width = 200;
			// 
			// pivotGridField2
			// 
			this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.pivotGridField2.AreaIndex = 0;
			this.pivotGridField2.Caption = "Gross Revenue";
			this.pivotGridField2.CellFormat.FormatString = "c";
			this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.pivotGridField2.FieldName = "GrossRevenue";
			this.pivotGridField2.Name = "pivotGridField2";
			// 
			// pivotGridField3
			// 
			this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.pivotGridField3.AreaIndex = 1;
			this.pivotGridField3.Caption = "Goal";
			this.pivotGridField3.CellFormat.FormatString = "c";
			this.pivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.pivotGridField3.FieldName = "GrossRevenueGoal";
			this.pivotGridField3.Name = "pivotGridField3";
			// 
			// fieldStatus
			// 
			this.fieldStatus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldStatus.AreaIndex = 2;
			this.fieldStatus.Caption = "Status";
			this.fieldStatus.Name = "fieldStatus";
			this.fieldStatus.UnboundFieldName = "Status";
			this.fieldStatus.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
			// 
			// fieldTrend
			// 
			this.fieldTrend.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTrend.AreaIndex = 3;
			this.fieldTrend.Caption = "Trend";
			this.fieldTrend.Name = "fieldTrend";
			this.fieldTrend.UnboundFieldName = "Trend";
			this.fieldTrend.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 465);
			this.Controls.Add(this.pivotGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PivotGridControlEx pivotGridControl1;
		private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
		private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
		private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
		private DevExpress.XtraPivotGrid.PivotGridField fieldStatus;
		private DevExpress.XtraPivotGrid.PivotGridField fieldTrend;
	}
}

