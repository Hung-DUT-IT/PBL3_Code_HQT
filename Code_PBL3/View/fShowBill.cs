using Code_PBL3.DAO;
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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using Code_PBL3.BUS;
using Aspose.Words;
using Aspose.Words.Tables;

namespace Code_PBL3
{
    public partial class fShowBill : Form
    {
        public delegate void Mydel(int id);
        public Mydel d { get; set; }
        private int idaAcc;

        public int IdAcc
        {
            get { return idaAcc; }
            set
            {
                idaAcc = value;
            }
        }
        private int idBill;

        public int IdBill
        {
            get { return idBill; }
            set
            {
                idBill = value;
            }
        }
        private float totalPrice;

        public float TotalPrice
        {
            get { return totalPrice; }
            set
            {
                totalPrice = value;
            }
        }
        private int  discount;
        public int Discount
        {
            get { return discount; }
            set
            {
                discount = value;
            }
        }
        public fShowBill(int idAcc,int idbill, float totalPrice, int discount)
        {
            InitializeComponent();
            this.IdAcc = idAcc;
            this.IdBill = idbill;
            this.TotalPrice = totalPrice;
            this.Discount = discount;
        }

        private void fShowBill_Load(object sender, EventArgs e)
        {
            lbIDAcc.Text = IdAcc.ToString();
            Bill bill = BillBUS.Instance.GetBillByIdBill(IdBill);
            lbNameTable.Text = TableFoodBUS.Instance.GetNameTableByIdBill(IdBill).ToString();
            lbDateCheckIn.Text = bill.DateCheckIn.ToString();
            lbDateCheckOut.Text = DateTime.Now.ToString();
            lbTotalPrice.Text = this.TotalPrice.ToString();
            lbDissCount.Text = this.Discount.ToString();
            float finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            lbTotalEnd.Text = finalTotalPrice.ToString();
            txbMoneyCus.Text = lbTotalEnd.Text;
            lbRefund.Text = (Convert.ToDouble(txbMoneyCus.Text) - Convert.ToDouble(lbTotalEnd.Text)).ToString();
            dgvBill.DataSource = MenuBillBUS.Instance.GetListMenuByBill(this.IdBill);
        }

        private void fShowBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to print invoices? ?", "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillBUS.Instance.CheckOut(this.IdBill, this.Discount, (float)Convert.ToDouble(lbTotalEnd.Text));
                Document involve = new Document(@"C:\Users\huuhu\source\repos\PBL3_Code_HQT\Code_PBL3\BILL\Billdemox.doc");
                involve.MailMerge.Execute(new[] { "ID_Bill" }, new[] { IdBill.ToString() });
                involve.MailMerge.Execute(new[] { "TableName" }, new[] { lbNameTable.Text });
                involve.MailMerge.Execute(new[] { "DateCheckIn" }, new[] { lbDateCheckIn.Text });
                involve.MailMerge.Execute(new[] { "DateCheckOut" }, new[] { lbDateCheckOut.Text });
                Table InvolveDetail = involve.GetChild(NodeType.Table, 1, true) as Table;
                int HangHienTai = 1;
                InvolveDetail.InsertRows(HangHienTai, HangHienTai, dgvBill.RowCount - 1); // thêm hàng ( hàng = billfor -1)
                for (int i = 0; i < dgvBill.RowCount; i++)
                {
                    InvolveDetail.PutValue(HangHienTai, 0, HangHienTai.ToString());
                    InvolveDetail.PutValue(HangHienTai, 1, dgvBill.Rows[i].Cells[0].Value.ToString());
                    InvolveDetail.PutValue(HangHienTai, 2, dgvBill.Rows[i].Cells[1].Value.ToString());
                    InvolveDetail.PutValue(HangHienTai, 3, dgvBill.Rows[i].Cells[2].Value.ToString());
                    InvolveDetail.PutValue(HangHienTai, 4, dgvBill.Rows[i].Cells[3].Value.ToString());
                    HangHienTai++;
                }               
                involve.MailMerge.Execute(new[] { "TotalPrice" }, new[] { lbTotalPrice.Text });
                involve.MailMerge.Execute(new[] { "Discount" }, new[] { lbDissCount.Text });
                involve.MailMerge.Execute(new[] { "finalTotalPrice" }, new[] { lbTotalEnd.Text });
                if(txbMoneyCus.Text != "")
                {
                    involve.MailMerge.Execute(new[] { "GuestGive" }, new[] { lbTotalEnd.Text });
                }
                else
                {
                    involve.MailMerge.Execute(new[] { "GuestGive" }, new[] { txbMoneyCus.Text });
                }                
                involve.MailMerge.Execute(new[] { "refunds" }, new[] { lbRefund.Text });
                involve.SaveAndOpenFile("Bill " + this.IdBill + ".doc");
                e.Cancel = false;   
            }

            else
            {
                BillBUS.Instance.CheckOut(this.IdBill, this.Discount, (float)Convert.ToDouble(lbTotalEnd.Text));
                e.Cancel = false;
            }
        }

        private void txbMoneyCus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbRefund.Text = (Convert.ToDouble(txbMoneyCus.Text) - Convert.ToDouble(lbTotalEnd.Text)).ToString();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
