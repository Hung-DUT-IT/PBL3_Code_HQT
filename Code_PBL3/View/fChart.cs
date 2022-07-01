using Code_PBL3.BUS;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Code_PBL3.View
{
    public partial class fChart : Form
    {
        public fChart()
        {
            InitializeComponent();
            SalesBUS.Instance.LoadSales();
        }

        private void fChart_Load(object sender, EventArgs e)
        {
            ChartSales.ChartAreas["ChartArea1"].AxisX.Title = "Month";
            ChartSales.ChartAreas["ChartArea1"].AxisY.Title = "Sales";
            foreach (Sales item in SalesBUS.Instance.GetAllSales())
            {
                ChartSales.Series["Total Price"].Points.AddXY(item.NameMonth, item.TotalPrice);
                if (item.TotalPrice > 0)
                {
                    ChartSalesC.Series["Total Price"].Points.AddXY(item.NameMonth, item.TotalPrice);
                }
               
            }
        }
    }
}
