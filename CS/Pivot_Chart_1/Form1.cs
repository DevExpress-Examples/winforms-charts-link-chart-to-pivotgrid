using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Pivot_Chart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'gspDataSet.GSP' table. You can move, or remove it, as needed.
            this.gSPTableAdapter.Fill(this.gspDataSet.GSP);
        }

        // Adjust the X-axis labels.
        private void chartControl1_CustomizeXAxisLabels(object sender, CustomizeXAxisLabelsEventArgs e) {
            e.Staggered = false;
        }

        // Change the series view type to Line.
        private void chartControl1_BoundDataChanged(object sender, EventArgs e) {
            ((ChartControl)sender).SeriesTemplate.ChangeView(ViewType.Line);
        }

    }
}
