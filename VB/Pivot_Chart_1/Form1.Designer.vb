Namespace Pivot_Chart
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
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet = New Pivot_Chart.gspDataSet()
            Me.fieldID1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldRegion1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGSP1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.gSPTableAdapter = New Pivot_Chart.gspDataSetTableAdapters.GSPTableAdapter()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gspDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.pivotGridControl1.DataSource = Me.gSPBindingSource
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldID1, Me.fieldRegion1, Me.fieldYear1, Me.fieldGSP1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 241)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGridControl1.Size = New System.Drawing.Size(823, 313)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' gSPBindingSource
            ' 
            Me.gSPBindingSource.DataMember = "GSP"
            Me.gSPBindingSource.DataSource = Me.gspDataSet
            ' 
            ' gspDataSet
            ' 
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldID1
            ' 
            Me.fieldID1.AreaIndex = 0
            Me.fieldID1.Caption = "ID"
            Me.fieldID1.FieldName = "ID"
            Me.fieldID1.Name = "fieldID1"
            ' 
            ' fieldRegion1
            ' 
            Me.fieldRegion1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldRegion1.AreaIndex = 0
            Me.fieldRegion1.Caption = "Region"
            Me.fieldRegion1.FieldName = "Region"
            Me.fieldRegion1.Name = "fieldRegion1"
            ' 
            ' fieldYear1
            ' 
            Me.fieldYear1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldYear1.AreaIndex = 0
            Me.fieldYear1.Caption = "Year"
            Me.fieldYear1.FieldName = "Year"
            Me.fieldYear1.Name = "fieldYear1"
            ' 
            ' fieldGSP1
            ' 
            Me.fieldGSP1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldGSP1.AreaIndex = 0
            Me.fieldGSP1.Caption = "GSP"
            Me.fieldGSP1.FieldName = "GSP"
            Me.fieldGSP1.Name = "fieldGSP1"
            ' 
            ' gSPTableAdapter
            ' 
            Me.gSPTableAdapter.ClearBeforeFill = True
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.chartControl1.DataSource = Me.pivotGridControl1
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.Title.Text = "Year"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = True
            xyDiagram1.AxisY.Title.Text = "GSP"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.MaxHorizontalPercentage = 30R
            Me.chartControl1.Location = New System.Drawing.Point(13, 13)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Series"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Me.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl1.Size = New System.Drawing.Size(822, 217)
            Me.chartControl1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(847, 566)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gSPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gspDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private gspDataSet As gspDataSet
        Private gSPBindingSource As System.Windows.Forms.BindingSource
        Private gSPTableAdapter As gspDataSetTableAdapters.GSPTableAdapter
        Private fieldID1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldRegion1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldYear1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldGSP1 As DevExpress.XtraPivotGrid.PivotGridField
        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl

    End Class
End Namespace

