using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_PBL3.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null) instance = new AccountBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private AccountBUS() { }
        public bool Login(string username, string password)
        {

            return AccountDAO.Instance.Login(username, EnCode(password));
        }
        public Account GetAccountByUserName(string UserName)
        {
            return AccountDAO.Instance.GetAccountByUserName(UserName);
        }
        public Account GetAccountByID(int id)
        {
            return AccountDAO.Instance.GetAccountByID(id);
        }
        public List<Account> LoadAccount()
        {
            return AccountDAO.Instance.LoadAccount();
        }
        public void AddAccount(string userName, string DisplayName, int Type, string pass)
        {
            if (AccountDAO.Instance.InsertAccount(userName, DisplayName, Type, pass))
            {
                MessageBox.Show("Successfully Added Account");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdd Account Failed ");
            }
        }
        public void UpadateAccount(string userName, int Type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, Type))
            {
                MessageBox.Show("Account Update Successful ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdd Update Failed ");
            }
        }
        public void DeleteAccount(int idac)
        {           
            if (AccountDAO.Instance.DeleteAccount(idac))
            {
                MessageBox.Show("Account Deleted Successfully");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdd Deleted Failed ");
            }
        }
        public List<Account> SearchAccByUserName(string usernam)
        {
            List<Account> listAcc = new List<Account>();
            listAcc = AccountDAO.Instance.SearchAccountByUserName(usernam);
            return listAcc;
        }
        public string EnCode(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        public void AlterPass(string currentpass, string newpass, string confirmpass, int idacc)
        {
            if(newpass != confirmpass )
            {
                MessageBox.Show("Confirm Invalid Password.\n Please re-enter.......");
            }
            else 
            {
                if(AccountDAO.Instance.AlterPass(EnCode(currentpass), EnCode(newpass), idacc))
                {
                    MessageBox.Show("Change password successfully.......\nPlease log in again!!!!!!! ");
                }
                else
                {
                    MessageBox.Show("Password change failed.\nPlease re-enter.......");
                }
            }
        }
        public int GetIDStaff(int idAcc)
        {
            return AccountDAO.Instance.GetIDStaff(idAcc);
        }
        public void UpdateAccountByMe(int idac, string displayName)
        {
            if (AccountDAO.Instance.UpdateAccountByMe(idac, displayName))
            {
                MessageBox.Show("Change account information successfully ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \n Change of account information failed ");
            }
        }
    }
}
