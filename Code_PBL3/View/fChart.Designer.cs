namespace Code_PBL3.View
{
    partial class fChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartSalesC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSalesC)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartSales
            // 
            this.ChartSales.BackColor = System.Drawing.Color.Bisque;
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            this.ChartSales.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(0, 0);
            this.ChartSales.Name = "ChartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Price";
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(737, 676);
            this.ChartSales.TabIndex = 0;
            this.ChartSales.Text = "chart1";
            // 
            // ChartSalesC
            // 
            this.ChartSalesC.BackColor = System.Drawing.Color.Bisque;
            chartArea2.Name = "ChartArea1";
            this.ChartSalesC.ChartAreas.Add(chartArea2);
            this.ChartSalesC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChartSalesC.Legends.Add(legend2);
            this.ChartSalesC.Location = new System.Drawing.Point(737, 0);
            this.ChartSalesC.Name = "ChartSalesC";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Total Price";
            this.ChartSalesC.Series.Add(series2);
            this.ChartSalesC.Size = new System.Drawing.Size(668, 676);
            this.ChartSalesC.TabIndex = 1;
            this.ChartSalesC.Text = "chart1";
            // 
            // fChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1405, 676);
            this.Controls.Add(this.ChartSalesC);
            this.Controls.Add(this.ChartSales);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu Đồ Thống Kê";
            this.Load += new System.EventHandler(this.fChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSalesC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSalesC;
    }
}