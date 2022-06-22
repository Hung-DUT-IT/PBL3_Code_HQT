﻿using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get 
            { 
                if (instance == null) instance = new AccountDAO(); 
                return instance; 
            }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {                    
            string query = "USP_LoginAccount @username = " + username + ", @password = '" + password + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string UserName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where UserName = '" + UserName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public Account GetAccountByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where IdAccount = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public List<Account> LoadAccount()
        {
            List<Account> accounts = new List<Account>();
            string query = "select * from Account where IsDeleted = 0 ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accounts.Add(account);
            }
            return accounts;
        }
        public bool InsertAccount(string userName, string displayName, int type,string pass)
        {
            string query = string.Format("insert into Account values ('{0}','{1}','{2}','{3}',{4})",1, userName, pass,  displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string userName, int type)
        {
            string query = string.Format("Update Account set Type = {1} where UserName = '{0}'", userName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(int idac)
        {
            string query = string.Format("Update Account set IsDeleted = 1 where IdAccount = {0} ", idac);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Account> SearchAccountByUserName(string userName)
        {
            List<Account> list = new List<Account>();
            string query = string.Format("select * from Account where dbo.GetUnsignString(UserName) like '%'+ dbo.GetUnsignString('{0}') + '%'", userName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account Acc = new Account(item);
                list.Add(Acc);
            }
            return list;
        }
        public bool AlterPass(string currentpass, string newpass, int idacc )
        {
            string query = string.Format("Update Account set Pass = '{0}' where IdAccount = {1} and Pass = '{2}' ", newpass, idacc, currentpass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int GetIDStaff(int idAcc)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteSaclar("select IdStaff from Account where IdAccount = " + idAcc);
            }
            catch
            {
                return -1;
            }
        }
        public bool UpdateAccountByMe(int idac, string displayName)
        {
            string query = string.Format("Update Account set DisplayName = N'{1}' where IdAccount = {0}", idac, displayName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
