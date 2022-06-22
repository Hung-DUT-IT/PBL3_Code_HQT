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
    public class AreaBUS
    {
        private static AreaBUS instance;
        public static AreaBUS Instance
        {
            get
            {
                if (instance == null) instance = new AreaBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private AreaBUS() { }
        public List<Area> LoadAreaList()
        {
            return AreaDAO.Instance.LoadAreaList();
        }
        public List<string> LoadNameArea()
        {
            return AreaDAO.Instance.LoadNameArea();
        }
        public void AddArea(string name)
        {
            if (AreaDAO.Instance.AddArea(name))
            {
                MessageBox.Show("Add Success Area ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdd Failed Area ");
            }
        }
        public void UpdateArea(int id, string name)
        {
            if (AreaDAO.Instance.UpdateArea(id, name))
            {
                MessageBox.Show("Area Update Successful");

            }
            else
            {
                MessageBox.Show("ERROR !!! \nArea Update Failed ");
            }
        }
        public void DelArea(int id)
        {

            if (AreaDAO.Instance.DeleteArea(id))
            {
                MessageBox.Show("Delete Area Successfully");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nArea Delete Failed ");
            }
        }
        public List<Area> SearchAreayName(string name)
        {
            List<Area> listArea = new List<Area>();
            listArea = AreaDAO.Instance.SearchAreaByName(name);
            return listArea;
        }
    }
}
