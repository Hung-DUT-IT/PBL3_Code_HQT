﻿using Code_PBL3.BUS;
using Code_PBL3.DAO;
using Code_PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_PBL3
{
    public partial class fStatic : Form
    {
        CultureInfo culture = new CultureInfo("vi-VN");
        public fStatic()
        {
            InitializeComponent();
            LoadDateTimePickerBill(); 
            LoadDGV();
            txbTotalSales.Text = BillBUS.Instance.GetTotalSales(DateFrom.Value.ToString(), DateTo.Value.ToString()).ToString("c", culture);
        }
        void LoadDGV()
        {
            dgvBill.DataSource = BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value, 1);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            DateFrom.Value = new DateTime(today.Year, today.Month, 1);
            DateTo.Value = DateFrom.Value.AddMonths(1).AddDays(-1);
        }
      
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            txbPageNumber.Text = "1";
            dgvBill.DataSource = BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value, 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageNumber.Text);
            int sumRecord = BillBUS.Instance.GetNumBillByDate(DateFrom.Value, DateTo.Value);
            if (page <= sumRecord / 20)
            {
                page++;
            }
            txbPageNumber.Text = page.ToString();
            dgvBill.DataSource = BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value, page);
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            txbPageNumber.Text = "1";
            dgvBill.DataSource= BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value,1);
            txbTotalSales.Text = BillBUS.Instance.GetTotalSales(DateFrom.Value.ToString(), DateTo.Value.ToString()).ToString("c", culture);
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txbPageNumber.Text);
            if (page > 1)
            {
                page--;
            }
            txbPageNumber.Text = page.ToString();
            dgvBill.DataSource=BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value, page);
        }

        private void btnEndPage_Click(object sender, EventArgs e)
        {

            int sumRecord = BillBUS.Instance.GetNumBillByDate(DateFrom.Value, DateTo.Value);
            int lastPage = sumRecord / 20;
            if (sumRecord % 10 != 0)
            {
                lastPage++;
            }
            txbPageNumber.Text = lastPage.ToString();
            dgvBill.DataSource = BillBUS.Instance.LoadListByDateAndPage(DateFrom.Value, DateTo.Value, lastPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fChart f1 = new fChart();
            f1.Show();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txbSearch.Text != "")
                {
                    dgvBill.DataSource = BillBUS.Instance.SearchBillById(Convert.ToInt32(txbSearch.Text));
                }
                else
                {
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
