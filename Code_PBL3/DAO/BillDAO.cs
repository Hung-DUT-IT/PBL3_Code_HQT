﻿using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public  class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO(); return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public Bill GetBillByIdBill(int idbill)
        {
            Bill bill = null;
            string query = "select * from Bill where IdBIll = " + idbill + " and IsDeleted = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                bill = new Bill(item);
                return bill;
            }
            return bill;
        }
        public int GetUnCheckBillIDByTableID(int idtable)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where IdTable = '" + idtable + "' " + "And Status = 0 ");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IdBill;
            }
            return -1;
        }
        public void CheckOut(int idBill, int discount, float totalPrice)
        {
            string query = "UPDATE Bill Set Status = 1," + "Discount = " + discount + ", TotalPrice = " + totalPrice + " where idBill = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void InsertBill(int idtable, int idAcc , DateTime checkOut )
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable , @idAc , @datecheckin  ", new object[] { idtable, idAcc , checkOut });
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkfrom , @checkto  ", new object[] { checkIn, checkOut });
        }
        public DataTable GetListBillByDateAndPage(DateTime checkIn, DateTime checkOut,int Page)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkfrom , @checkto , @page ", new object[] { checkIn, checkOut, Page });
        }
        public int GetMaxBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteSaclar("select Max(IdBill) from Bill");
            }
            catch
            {
                return -1;
            }

        }
        public void UpdateCusOnBill(int idbill,int idcus)
        {
            string query = "update Bill set IdCtm = "+ idcus + " where idBill = " + idbill;
            DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetNumBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteSaclar("exec USP_GetNumBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }
        public bool DelBIll(int idBill )
        {
            string query = "Delete bill where IdBill = " + idBill;
            int ressult = DataProvider.Instance.ExecuteNonQuery(query);
            return ressult > 0;
        }
        public Double GetTotalSales(string dateCheckInTo , string dateCheckInfrom)
        {
            try
            {
                return (Double)DataProvider.Instance.ExecuteSaclar("select SUM(TotalPrice) from Bill where  DateCheckIn >= '" + dateCheckInTo + "' and DateCheckIn <= '" + dateCheckInfrom +  "' ");
            }
            catch
            {
                return -1;
            }
        }
        public DataTable SearchBillById(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select IdBill as [Code Bill], TableFood.Name as [Name Table], BIll.TotalPrice as [Total Price], BIll.DateCheckIn as [Date CheckIn], BIll.Discount as [Discount] from TableFood inner join BIll on TableFood.IdTable = BIll.IdTable where BIll.IDBill like '%" + idBill + "%'");
            return data;
        }
    }
}
