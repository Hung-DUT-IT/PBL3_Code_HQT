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
        private double totalPrice;

        public double TotalPrice
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
        public fShowBill(int idAcc,int idbill, double totalPrice, int discount)
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
            lbNameTable.Text = TableDAO.Instance.GetNameTableByIdBill(IdBill).ToString();
            lbDateCheckIn.Text = bill.DateCheckIn.ToString();
            lbDateCheckOut.Text = DateTime.Now.ToString();
            lbTotalPrice.Text = this.TotalPrice.ToString();
            lbDissCount.Text = this.Discount.ToString();
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            lbTotalEnd.Text = finalTotalPrice.ToString();
            if(txbMoneyCus.Text == "")
            {
                lbRefund.Text = "0";
            }
            dgvBill.DataSource = MenuBillBUS.Instance.GetListMenuByBILL(this.IdBill);
        }

        private void fShowBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban có muốn in hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                BillDAO.Instance.CheckOut(this.IdBill, this.Discount, (float)Convert.ToDouble(lbTotalEnd.Text));
                //CreateWordDocument(@"C:\Users\huuhu\source\repos\PBL_3_Code\Code_PBL3\BILL", @"C:C:\Users\huuhu\source\repos\PBL_3_Code\Code_PBL3\BILL\Hoa Don" + this.IdBill + ".docx");
                //Process.Start(@"C:C:\Users\huuhu\source\repos\PBL_3_Code\Code_PBL3\BILL\Hoa Don" + this.IdBill + ".docx");             
                e.Cancel = false;
            }

            else
            {
                BillDAO.Instance.CheckOut(this.IdBill, this.Discount, (float)Convert.ToDouble(lbTotalEnd.Text));
                e.Cancel = false;
            }
        }
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replacewithText)
        {
            object matchCase = true;
            object matchWholeword = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchkashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeword,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replacewithText,
                ref replace, ref matchkashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;
            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;
                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                                   ref missing, ref missing, ref missing,
                                                   ref missing, ref missing, ref missing,
                                                   ref missing, ref missing, ref missing,
                                                   ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                this.FindAndReplace(wordApp, "<ID_Bill>", this.IdBill);
                this.FindAndReplace(wordApp, "<TableName>", lbNameTable.Text);
                this.FindAndReplace(wordApp, "<DateCheckIn>", lbDateCheckIn.Text);
                this.FindAndReplace(wordApp, "<DateCheckOut>", lbDateCheckOut.Text);
            }
            else
            {
                MessageBox.Show("File not found");
            }
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing);
            myWordDoc.Close();
            wordApp.Quit();
        }
    }
}
