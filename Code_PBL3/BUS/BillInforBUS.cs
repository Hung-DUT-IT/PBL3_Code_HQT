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
    public class BillInforBUS
    {
        private static BillInforBUS instance;
        public static BillInforBUS Instance
        {
            get
            {
                if (instance == null) instance = new BillInforBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private BillInforBUS() { }
        public List<BillInfor> GetListBIllIfor(int id)
        {
            return BillInforDAO.Instance.GetListBIllIfor(id);
        }
        public void InssertBillInfor(int idBill, int idFood, int count)
        {
            BillInforDAO.Instance.InssertBillInfor(idBill, idFood, count);
        }
        public void DeleteBillInforByFoodID(int id)
        {
            BillInforDAO.Instance.DeleteBillInforByFoodID(id);
        }
        public void DetachedBillInfor(int idBill_1, int idBill_2, int idFood, int count)
        {
            BillInforDAO.Instance.DetachedBillInfor(idBill_1, idBill_2, idFood, count);
        }
    }
}
