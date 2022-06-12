using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DTO
{
    public class Area
    {
        private int idArea;
        public int IDArea
        {
            get { return idArea; }
            set { idArea = value; }
        }
        private string nameArea;
        public string NameArea
        {
            get { return nameArea; }
            set { nameArea = value; }
        }
        public int isDeleted;
        public int IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        public Area(int id, string name, int isDeleted)
        {
            this.IDArea = id;
            this.NameArea = name;
            this.IsDeleted = isDeleted;
        }

        public Area(DataRow row)
        {
            this.IDArea = (int)row["IdArea"];
            this.NameArea = row["Name"].ToString();
            this.IsDeleted = (int)row["IsDeleted"];
        }
    }
}
