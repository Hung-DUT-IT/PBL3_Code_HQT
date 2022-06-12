using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DTO
{
    public class BillInfor
    {
        private int iDBillInfor;

        public int IDBillInfor
        {
            get { return iDBillInfor; }
            set { iDBillInfor = value; }
        }
        
        private int idBill;
        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        private string iDfood;
        public string IDFood
        {
            get { return iDfood; }
            set { iDfood = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int isDeleted;
        public int IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        public BillInfor(int id, int billid, string foodid, int count, int isDeleted)
        {
            this.IDBillInfor = id;
            this.IdBill = billid;
            this.IDFood = foodid;
            this.Count = count;
            this.IsDeleted = isDeleted;
        }
        public BillInfor(DataRow rows)
        {
            this.IDBillInfor = (int)rows["id"];
            this.IdBill = (int)rows["idbIll"];
            this.IDFood = rows["idfood"].ToString();
            this.Count = (int)rows["count"];
            this.IsDeleted = (int)rows["IsDeleted"];
        }
    }
}
