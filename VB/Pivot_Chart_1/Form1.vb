Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Pivot_Chart
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)
		End Sub

		' Adjust the X-axis labels.
		Private Sub chartControl1_CustomizeXAxisLabels(ByVal sender As Object, ByVal e As CustomizeXAxisLabelsEventArgs) Handles chartControl1.CustomizeXAxisLabels
			e.Staggered = False
		End Sub

		' Change the series view type to Line.
		Private Sub chartControl1_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.BoundDataChanged
			DirectCast(sender, ChartControl).SeriesTemplate.ChangeView(ViewType.Line)
		End Sub

	End Class
End Namespace
