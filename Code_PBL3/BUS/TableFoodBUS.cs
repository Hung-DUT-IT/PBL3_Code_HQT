using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_PBL3.BUS
{
    public class TableFoodBUS
    {
        private static TableFoodBUS instance;
        public static TableFoodBUS Instance
        {
            get
            {
                if (instance == null) instance = new TableFoodBUS();
                return instance;
            }
            private set { instance = value; }
        }
        public static double TableWidth = 143;
        public static double TableHeight = 143;
        public List<TableFood> LoadTableList()
        {
            return TableFoodDAO.Instance.LoadTableList();
        }
        public List<TableFood> LoadTableListByArea(string namearea)
        {

            return TableFoodDAO.Instance.LoadTableListByArea(namearea);
        }
        public string GetNameTableByIdBill(int idbill)
        {
            return TableFoodDAO.Instance.GetNameTableByIdBill(idbill);
        }
        public TableFood GetTableByID(int id)
        {
            return TableFoodDAO.Instance.GettabletByID(id);
        }
        public void SwitchTable(int idtable1, int idtable2, int idAcc, DateTime checkIn)
        {
            TableFoodDAO.Instance.SwitchTable(idtable1, idtable2, idAcc, checkIn);
        }
        public void AddTable(int idarea, string name)
        {
            if (TableFoodDAO.Instance.AddTable(idarea, name))
            {
                MessageBox.Show("Successfully Added Dining Table");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdding Dining Table Failed");
            }
        }
        public void UpdateTable(int idtable, int idarea, string name, string status, int isDelete)
        {
            if (TableFoodDAO.Instance.UpdateTable(idtable, idarea, name, status, isDelete))
            {
                MessageBox.Show("Successfully Update Dining Table");

            }
            else
            {
                MessageBox.Show("ERROR !!! \n Update Dining Table Failed");
            }
        }
        public void DelTable(int id)
        {

            if (TableFoodDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Successfully Delete Dining Table ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \n Delete Dining Table Failed");
            }
        }
        public List<TableFood> SearchTableByName(string name)
        {
            List<TableFood> listTable = new List<TableFood>();
            listTable = TableFoodDAO.Instance.SearchTableByName(name);
            return listTable;
        }
        
        public void UpdateSatus(int idtable)
        {
            TableFoodDAO.Instance.UpdateStatus(idtable);
        }
    }
}
