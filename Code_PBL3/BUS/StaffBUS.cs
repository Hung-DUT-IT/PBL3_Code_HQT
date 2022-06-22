using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_PBL3.BUS
{
    public class StaffBUS
    {
        private static StaffBUS instance;
        public static StaffBUS Instance
        {
            get
            {
                if (instance == null) instance = new StaffBUS();
                return instance;
            }
            private set { instance = value; }
        }
        public Staff GetStaffByIDAcc(int idacc)
        {
            return StaffDAO.Instance.GetStaffByIDAcc(idacc);
        }
        public List<Staff> LoadStaff()
        {
            return StaffDAO.Instance.LoadStaff();
        }
        public void UpdateStaffByMe(int idStaff, string Name, string Phone)
        {
            if (StaffDAO.Instance.UpdateStaffByMe(idStaff, Name, Phone))
            {
                MessageBox.Show("Successfully Updated Information");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nInformation Update Failed");
            }
        }
        public void UpdateStaffByAdmin(int idStaff, string Name, string Positon, string Shitf)
        {
            if (StaffDAO.Instance.UpdateStaffByAdmin(idStaff, Name, Positon, Shitf))
            {
                MessageBox.Show("Employee Update Successful");

            }
            else
            {
                MessageBox.Show("ERROR !!! \nEmployee Update Failed ");
            }
        }
        public void DelStafff(int idstaff)
        {

            if (StaffDAO.Instance.DeleteStaff(idstaff))
            {
                MessageBox.Show("Employee Delete Successful");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nEmployee Delete Failed ");
            }
        }
        public void AddStaff(string name, string Phone, string Position, string Shift)
        {
            if (StaffDAO.Instance.InsertStaff(name, Phone, Position, Shift))
            {
                MessageBox.Show("Employee Add Successful");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nEmployee Add Failed ");
            }

        }
        public List<Staff> SearchStaffByName(string name)
        {
            List<Staff> listStaff = new List<Staff>();
            listStaff = StaffDAO.Instance.SearchStaffByName(name);
            return listStaff;
        }

    }
}
