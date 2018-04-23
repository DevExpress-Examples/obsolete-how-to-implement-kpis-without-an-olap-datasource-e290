using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.PivotGrid;
using System.Collections;

namespace KPIWithoutOLAP {
	public partial class Form1 : Form {
		PivotKPIGraphic statusGraphic = PivotKPIGraphic.Cylinder,
			trendGraphic = PivotKPIGraphic.StatusArrow;

		public Form1() {
			InitializeComponent();

			Random r = new Random();

			DataTable table = new DataTable();
			table.Columns.Add("Year", typeof(int));
            table.Columns.Add("Department", typeof(string));
			table.Columns.Add("GrossRevenue", typeof(int));
			table.Columns.Add("GrossRevenueGoal", typeof(int));
			table.Rows.Add(2005, "Dep. A", r.Next(10000000), r.Next(10000000));
            table.Rows.Add(2006, "Dep. A", r.Next(10000000), r.Next(10000000));
            table.Rows.Add(2007, "Dep. A", r.Next(10000000), r.Next(10000000));
            table.Rows.Add(2005, "Dep. B", r.Next(10000000), r.Next(10000000));
            table.Rows.Add(2006, "Dep. B", r.Next(10000000), r.Next(10000000));
            table.Rows.Add(2007, "Dep. B", r.Next(10000000), r.Next(10000000));
			pivotGridControl1.DataSource = table;
		}

		void pivotGridControl1_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e) {
			e.Value = 0;	// we have two fake columns: Status and Trend
		}

		private void pivotGridControl1_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e) {
			if(e.DataField != fieldStatus && e.DataField != fieldTrend) return;
			Bitmap bitmap = null;
			if(e.DataField == fieldStatus)
				bitmap = pivotGridControl1.GetKPIBitmap(statusGraphic, GetStatusValue(e));
			else
				bitmap = pivotGridControl1.GetKPIBitmap(trendGraphic, GetTrendValue(e));
			e.Graphics.FillRectangle(new SolidBrush(e.Appearance.BackColor), e.Bounds);
            if(e.DataField != fieldTrend || e.RowValueType != PivotGridValueType.GrandTotal) {
                e.Graphics.DrawImage(bitmap,
                        e.Bounds.Left + (e.Bounds.Width - bitmap.Width) / 2,
                        e.Bounds.Top + (e.Bounds.Height - bitmap.Height) / 2);
            }
			e.Handled = true;
		}

		int GetStatusValue(PivotCustomDrawCellEventArgs e) {
            int revenue = Convert.ToInt32(e.GetCellValue(fieldRevenue)),
                goal = Convert.ToInt32(e.GetCellValue(fieldGoal));
			return Comparer.Default.Compare(revenue, goal);
		}

		int GetTrendValue(PivotCustomDrawCellEventArgs e) {
			if(e.RowIndex == 0) return 0;
            object prevYearRevenue = e.GetPrevRowCellValue(fieldRevenue),
                   thisYearRevenue = e.GetCellValue(fieldRevenue);
			return Comparer.Default.Compare(thisYearRevenue, prevYearRevenue);
		}
	}
}