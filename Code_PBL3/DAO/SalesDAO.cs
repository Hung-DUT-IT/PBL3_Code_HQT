using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public class SalesDAO
    {
        private static SalesDAO instance;

        public static SalesDAO Instance
        {
            get
            {
                if (instance == null) instance = new SalesDAO();
                return SalesDAO.instance;
            }
            set { SalesDAO.instance = value; }
        }
        private SalesDAO() { }
        public List<Sales> GetAllSales()
        {
            List<Sales> sales = new List<Sales>();
            string query = "select * from sales ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Sales sale = new Sales(item);
                sales.Add(sale);
            }
            return sales;
        }
        public void LoadSales()
        {
            string query = "exec USP_Sale";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
