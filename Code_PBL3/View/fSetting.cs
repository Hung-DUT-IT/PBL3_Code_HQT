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

namespace Code_PBL3
{
    public partial class fSetting : Form
    {
        private int idAccount;
        public int AccountID
        {
            get { return idAccount; }
            set { idAccount = value; }
        }
        private int idStaff ;
        public int IdStaff
        {
            get { return idStaff; }
            set { idStaff = value; }
        }
        public fSetting(int idAcc, int idStaff)
        {
            InitializeComponent();
            this.AccountID = idAcc;
            this.IdStaff = idStaff; 
            LoadStaff();
            LoadAccount();
        }
        void LoadStaff()
        {
            Staff st = StaffBUS.Instance.GetStaffByIDAcc(this.AccountID);
            txbIdStaff.Text = st.IdStaff.ToString();
            txbPosition.Text = st.Position.ToString();
            txbNamestaff.Text = st.NameStaff.ToString();
            txbPhone.Text = st.Phone.ToString();
            txbShift.Text = st.Shift.ToString();
        }
        void LoadAccount()
        {
            Account ac = AccountBUS.Instance.GetAccountByID(this.AccountID);
            txbIdAccount.Text = ac.IdAccount.ToString();
            txbUserName.Text = ac.UserName.ToString();
            txbPass.Text = ac.PassWord.ToString();
            txbDisplayName.Text = ac.DisPlayName.ToString();
            if (ac.Type == 1)
            {
                txbTypeAccount.Text = "Account Type Management"; 
            }
            else txbTypeAccount.Text = "Account Type Employee";
        }
        private void tabPInformationStaff_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentpass = txbCurrentPass.Text;
            string newPass = txbNewPass.Text;
            string confrimpass = txbConfrimPass.Text;
            AccountBUS.Instance.AlterPass(currentpass, newPass, confrimpass,this.AccountID);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string name = txbNamestaff.Text;
            string phone = txbPhone.Text;
            StaffBUS.Instance.UpdateStaffByMe(this.IdStaff, name, phone);
        }

        private void btUpdateAcc_Click(object sender, EventArgs e)
        {
            string displayName = txbDisplayName.Text;
            AccountBUS.Instance.UpdateAccountByMe(this.AccountID, displayName);
        }
    }
}
