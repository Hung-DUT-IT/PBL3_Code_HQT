using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DTO
{
    public class Sales
    {
        private string nameMonth;
        public string NameMonth
        {
            get { return nameMonth; }
            set { nameMonth = value; }
        }

        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public Sales(DataRow row)
        {
            this.NameMonth = row["Month"].ToString();
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPice"].ToString());
        }
    }
}
