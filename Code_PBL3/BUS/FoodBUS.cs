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
    public class FoodBUS
    {
        private static FoodBUS instance;
        public static FoodBUS Instance
        {
            get
            {
                if (instance == null) instance = new FoodBUS();
                return instance;
            }
            private set { instance = value; }
        }
        public static double FoodWidth = 148;
        public static double FoodHeight = 60;
        public List<Food> GetListFood()
        {
            return FoodDAO.Instance.GetListFood();
        }
        public List<Food> GetListFoodByCategory(int id)
        {
            return FoodDAO.Instance.GetListFoodByCategory(id);
        }
        public Food GetFoodByName(string name)
        {
            return FoodDAO.Instance.GetFoodByName(name);
        }
        public void UpdateFood(int idfood, int foodcategory, string name, int price)
        {
            if (FoodDAO.Instance.UpdateFood(idfood, foodcategory, name, price))
            {
                MessageBox.Show("Successful Food update");

            }
            else
            {
                MessageBox.Show("ERROR !!! \nFood update failed");
            }
        }
        public void AddFood(string name, int category, int price)
        {
            if (FoodDAO.Instance.AddFood(name, category, price))
            {
                MessageBox.Show("Successful Food Add");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nFood Add failed ");
            }
        }

        public void DelFood(int idfood)
        {

            if (FoodDAO.Instance.DeleteFood(idfood))
            {
                MessageBox.Show("Successful Food Delete");
            }
            else
            {
                MessageBox.Show("ERROR !!! \n Food Delete failed ");
            }
        }
        public List<Food> SearchAccByName(string name)
        {
            List<Food> listFood = new List<Food>();
            listFood = FoodDAO.Instance.SearchAccountByName(name);
            return listFood;
        }
    }
}
