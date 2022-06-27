using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public class TableFoodDAO
    {
        private static TableFoodDAO instance;
        public static TableFoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableFoodDAO();
                return TableFoodDAO.instance;
            }
            private set { TableFoodDAO.instance = value; }
        }
        private TableFoodDAO() { }
        public List<TableFood> LoadTableList()
        {
            List<TableFood> tablelist = new List<TableFood>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                TableFood table = new TableFood(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public List<TableFood> LoadTableListByArea(string namearea)
        {
            List<TableFood> tablelist = new List<TableFood>();
            if(namearea == "All")
            {
                return tablelist = LoadTableList();
            }
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_GetTableListByArea  @namearea = '" + namearea +"'");
            foreach (DataRow item in data.Rows)
            {
                TableFood table = new TableFood(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public string GetNameTableByIdBill(int idbill)
        {
            string name = "";
            string query = "select Name  from TableFood  inner join BIll on TableFood.IdTable = BIll.IdTable where IdBIll = " + idbill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                name = item[0].ToString();
            }
            return name;
        }
        public TableFood GettabletByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TableFood where IdTable = " + id );
            foreach (DataRow item in data.Rows)
            {
                return new TableFood(item);
            }
            return null;
        }
        public void SwitchTable(int idtable1, int idtable2, int idAcc, DateTime checkIn)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2 , @idAccount , @datecheckin ", new object[] { idtable1, idtable2, idAcc , checkIn });
        }
        public bool AddTable(int idarea, string name, string status = "Trống", int isDelete = 0 )
        {
            string query = String.Format("insert into TableFood values ({0},N'{1}',N'{2}',{3})", idarea, name, status, isDelete);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(int idtable, int idarea, string name, string status, int isDelete)
        {

            string query = String.Format("update TableFood set IdArea = {0}, Name = '{1}' ,Status = N'{2}', Isdelete = {3}  where IdTable = {4} ", idarea, name, status, isDelete, idtable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int idtable )
        {
            string query = String.Format("update TableFood set Isdeleted = 1 where IdTable = {0} ", idtable);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<TableFood> SearchTableByName(string name)
        {
            List<TableFood> list = new List<TableFood>();
            string query = string.Format("select * from TableFood where dbo.GetUnsignString(Name) like  '%' +  dbo.GetUnsignString('{0}') +'%' " , name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableFood table = new TableFood(item);
                list.Add(table);
            }
            return list;
        }
        public void UpdateStatus(int idtable )
        {
            string query = "update TableFood Set status = N'Trống' where IdTable = " + idtable;
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
