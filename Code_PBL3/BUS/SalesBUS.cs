using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.BUS
{
    public class SalesBUS
    {
        private static SalesBUS instance;
        public static SalesBUS Instance
        {
            get
            {
                if (instance == null) instance = new SalesBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private SalesBUS() { }
        public List<Sales> GetAllSales()
        {
            return SalesDAO.Instance.GetAllSales();
        }
        public void LoadSales()
        {
            SalesDAO.Instance.LoadSales();
        }
    }
}
