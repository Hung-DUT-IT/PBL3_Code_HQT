using Code_PBL3.BUS;
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

namespace Code_PBL3.View
{
    public partial class fDetachedBill : Form
    {
        public delegate void Mydel(string nameArea);
        public Mydel d { get; set; }
        private int idTableOrigin ; 
        public int IdTableOrigin
        {
            get { return idTableOrigin; }
            set { idTableOrigin = value; }
        }
        private int idTableDeTached;
        public int IdTableTached
        {
            get { return idTableDeTached; }
            set { idTableDeTached = value; }
        }
        private int idAcc;
        public int IdAcc
        {
            get { return idAcc; }
            set { idAcc = value; }
        }
        public int idbillNew; 
        public fDetachedBill(int idTableOrigin, int idTableDeTached, int idacc)
        {
            InitializeComponent();
            this.IdTableOrigin = idTableOrigin;
            this.IdTableTached = idTableDeTached;
            this.IdAcc = idacc;
        }

        private void fDetachedBill_Load(object sender, EventArgs e)
        {
            int idBill_1 = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableOrigin);
            this.idbillNew = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableTached);
            if(this.idbillNew == -1 )
            {
                // tao bill moi 
                BillDAO.Instance.InsertBill(this.IdTableTached, this.IdAcc, DateTime.Now);
                this.idbillNew = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableTached);
            }

            TableFood table1 = TableFoodBUS.Instance.GetTableByID(this.IdTableOrigin);
            TableFood table2 = TableFoodBUS.Instance.GetTableByID(this.IdTableTached);
            
            dgvOriginTable.DataSource = MenuBillBUS.Instance.GetListMenuByBill(idBill_1);
            
            
            txbTableOrigin.Text = table1.NameTable.ToString();
            txbAreaOrigin.Text = table1.IdArea.ToString();
            txbBillOrigin.Text = idBill_1.ToString();

            txbTableDetached.Text = table2.NameTable.ToString();
            txbAreaDetached.Text = table2.IdArea.ToString();
            txbBillDetached.Text = this.idbillNew.ToString();
        }

        private void DetachedTo_Click(object sender, EventArgs e)
        {
            if (dgvOriginTable.SelectedRows.Count == 1)
            {
                if(dgvOriginTable.Rows.Count > 1)
                {
              
                    string name = dgvOriginTable.SelectedRows[0].Cells["FoodName"].Value.ToString();
                    int idBill_1 = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableOrigin);
                    int count = (int)nmCounts.Value;
                    BillInforDAO.Instance.DetachedBillInfor(idBill_1, this.idbillNew, FoodBUS.Instance.GetFoodByName(name).IDFood, count);
                    dgvDetached.DataSource = MenuBillBUS.Instance.GetListMenuByBill(this.idbillNew);
                    dgvOriginTable.DataSource = MenuBillBUS.Instance.GetListMenuByBill(idBill_1);
                }
                else
                {
                    MessageBox.Show("Không Thể Chuyển Món Thêm Được Nữa\nMuon Chuyen Het Vui Long Chon Chuyen Ban !!");
                }
            }
        }

        private void DetachedBack_Click(object sender, EventArgs e)
        {
            if (dgvDetached.SelectedRows.Count == 1)
            {
                string name = dgvDetached.SelectedRows[0].Cells["FoodName"].Value.ToString();
                int idBill_1 = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableOrigin);
                int count = (int)nmCounts.Value;
                BillInforDAO.Instance.DetachedBillInfor(this.idbillNew, idBill_1, FoodBUS.Instance.GetFoodByName(name).IDFood, count);
                dgvOriginTable.DataSource = MenuBillBUS.Instance.GetListMenuByBill(idBill_1);
                dgvDetached.DataSource = MenuBillBUS.Instance.GetListMenuByBill(this.idbillNew);
            }
        }

        private void DetachedBackAll_Click(object sender, EventArgs e)
        {
            int idBill_1 = BillDAO.Instance.GetUnCheckBillIDByTableID(this.IdTableOrigin);
            for (int i = 0; i < dgvDetached.Rows.Count; i++)
            {
                string name = dgvOriginTable.SelectedRows[0].Cells["FoodName"].Value.ToString();
                int count = (int)nmCounts.Value;
                BillInforBUS.Instance.DetachedBillInfor(this.idbillNew, idBill_1, FoodBUS.Instance.GetFoodByName(name).IDFood, count);
                dgvDetached.DataSource = MenuBillBUS.Instance.GetListMenuByBill(this.idbillNew);
                dgvOriginTable.DataSource = MenuBillBUS.Instance.GetListMenuByBill(idBill_1);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (dgvDetached.Rows.Count > 0)
            {
                this.Close();
                this.d("All");
            }
            else
            {
                if (BillBUS.Instance.DelBill(this.idbillNew))
                {
                    MessageBox.Show("Bạn Đã Hủy Tách Hóa Đơn Hành Công !!!");
                    TableFoodBUS.Instance.UpdateSatus(this.idTableDeTached);
                    this.Close();
                    this.d("All");
                }
            }
        }
    }
}