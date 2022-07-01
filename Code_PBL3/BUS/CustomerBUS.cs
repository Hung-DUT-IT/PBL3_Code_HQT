using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null) instance = new CustomerBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private CustomerBUS() { }
        public List<Customer> GetListCus()
        {
            return CustomerDAO.Instance.GetListCus();
        }
        public Customer GetCusByPhone(string phone)
        {
            return CustomerDAO.Instance.GetCusByPhone(phone);
        }
        public bool InserterCus(string Name, string Phone)
        {
            return CustomerDAO.Instance.InserterCus(Name,Phone);
        }
        public int GetIDCusByPhone(string phone)
        {
            return CustomerDAO.Instance.GetIDCusByPhone(phone);
        }
        public void UpdatePointCus(int idCus)
        {
            CustomerDAO.Instance.UpdatePointCus(idCus);
        }
        public List<Customer> SearchCusByName(string Name)
        {
            return CustomerDAO.Instance.SearchCusByName(Name);
        }
    }
}
