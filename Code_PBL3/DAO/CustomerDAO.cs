﻿using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            set { CustomerDAO.instance = value; }
        }
        private CustomerDAO() { }
        public List<Customer> GetListCus()
        {
            List<Customer> list = new List<Customer>();
            string query = "select * from Customer where IsDeleted = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }
        public Customer GetCusByPhone(string phone)
        {
            Customer cus = null;
            string query = "select * from Customer where Phone = '" + phone + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cus = new Customer(item);
                return cus;
            }
            return cus;
        }
        public bool InserterCus(string Name ,string Phone)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertCus @TenKH , @Phone", new object[] { Name, Phone });
            return result > 0;
        }
        public int GetIDCusByPhone(string phone)
        {
            try
            {
                string query = "select IdCtm from Customer where Phone = '" + phone + "'";
                return (int)DataProvider.Instance.ExecuteSaclar(query);
            }
            catch
            {
                return -1;
            }

        }
        public void UpdatePointCus(int idCus)
        {
            DataProvider.Instance.ExecuteQuery("update Customer set Point = Point + 10 where IdCtm = " + idCus);
        }
        public List<Customer> SearchCusByName(string Name)
        {
            List<Customer> list = new List<Customer>();
            string query = string.Format("select * from Customer where dbo.GetUnsignString(Name) like '%'+ dbo.GetUnsignString('{0}') + '%'", Name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }
    }
}
