using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null) instance = new BillBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private BillBUS() { }
        public DataTable LoadListByDate(DateTime CheckIn, DateTime CheckOut)
        {
            return BillDAO.Instance.GetListBillByDate(CheckIn, CheckOut);
        }
        public DataTable LoadListByDateAndPage(DateTime CheckIn, DateTime CheckOut,int Page)
        {
            return BillDAO.Instance.GetListBillByDateAndPage(CheckIn, CheckOut, Page);
        }
        public Bill GetBillByIdBill(int idbill)
        {
            return BillDAO.Instance.GetBillByIdBill(idbill);
        }
        public int GetUnCheckBillIDByTableID(int idtable)
        {
            return BillDAO.Instance.GetUnCheckBillIDByTableID(idtable);
        }
        public void CheckOut(int idBill, int discount, float totalPrice)
        {
            BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
        }
        public void InsertBill(int idtable, int idAcc, DateTime checkOut)
        {
            BillDAO.Instance.InsertBill(idtable,idAcc, checkOut);
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }
        public DataTable GetListBillByDateAndPage(DateTime checkIn, DateTime checkOut, int Page)
        {
            return BillDAO.Instance.GetListBillByDateAndPage(checkIn, checkOut, Page);
        }
        public int GetMaxBill()
        {
            return BillDAO.Instance.GetMaxBill();
        }
        public int GetNumBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return BillDAO.Instance.GetNumBillByDate(checkIn, checkOut);  
        }
        public bool UpdateCusOnBill(int idbill, string idcus)
        {
            return BillDAO.Instance.UpdateCusOnBill(idbill, idcus);
        }
        public bool DelBill(int idbill)
        {
            return BillDAO.Instance.DelBIll(idbill);
        }
        public Double GetTotalSales()
        {
            return BillDAO.Instance.GetTotalSales();
        }
    }
}
