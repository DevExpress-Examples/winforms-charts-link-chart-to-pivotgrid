namespace Pivot_Chart {
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.gSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gspDataSet = new Pivot_Chart.gspDataSet();
            this.fieldID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRegion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGSP1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.gSPTableAdapter = new Pivot_Chart.gspDataSetTableAdapters.GSPTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.gSPBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldID1,
            this.fieldRegion1,
            this.fieldYear1,
            this.fieldGSP1});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 241);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.Size = new System.Drawing.Size(823, 313);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // gSPBindingSource
            // 
            this.gSPBindingSource.DataMember = "GSP";
            this.gSPBindingSource.DataSource = this.gspDataSet;
            // 
            // gspDataSet
            // 
            this.gspDataSet.DataSetName = "gspDataSet";
            this.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldID1
            // 
            this.fieldID1.AreaIndex = 0;
            this.fieldID1.Caption = "ID";
            this.fieldID1.FieldName = "ID";
            this.fieldID1.Name = "fieldID1";
            // 
            // fieldRegion1
            // 
            this.fieldRegion1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldRegion1.AreaIndex = 0;
            this.fieldRegion1.Caption = "Region";
            this.fieldRegion1.FieldName = "Region";
            this.fieldRegion1.Name = "fieldRegion1";
            // 
            // fieldYear1
            // 
            this.fieldYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldYear1.AreaIndex = 0;
            this.fieldYear1.Caption = "Year";
            this.fieldYear1.FieldName = "Year";
            this.fieldYear1.Name = "fieldYear1";
            // 
            // fieldGSP1
            // 
            this.fieldGSP1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGSP1.AreaIndex = 0;
            this.fieldGSP1.Caption = "GSP";
            this.fieldGSP1.FieldName = "GSP";
            this.fieldGSP1.Name = "fieldGSP1";
            // 
            // gSPTableAdapter
            // 
            this.gSPTableAdapter.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Title.Text = "Year";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.Title.Text = "GSP";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(13, 13);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(822, 217);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chartControl1_BoundDataChanged);
            this.chartControl1.PivotChartingCustomizeXAxisLabels += new DevExpress.XtraCharts.CustomizeXAxisLabelsEventHandler(this.chartControl1_CustomizeXAxisLabels);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 566);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private gspDataSet gspDataSet;
        private System.Windows.Forms.BindingSource gSPBindingSource;
        private gspDataSetTableAdapters.GSPTableAdapter gSPTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRegion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGSP1;
        private DevExpress.XtraCharts.ChartControl chartControl1;

    }
}

