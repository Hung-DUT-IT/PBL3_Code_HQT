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
    public class CategoryBUS
    {
        private static CategoryBUS instance;
        public static CategoryBUS Instance
        {
            get
            {
                if (instance == null) instance = new CategoryBUS();
                return instance;
            }
            private set { instance = value; }
        }
        private CategoryBUS() { }
        public static double CategoryWidth = 160;
        public static double CategoryHeight = 60;
        public List<Category> GetListCategory()
        {
            return CategoryDAO.Instance.GetListCategory();
        }
        public Category GetCategoryByID(int id)
        {
            return CategoryDAO.Instance.GetCategoryByID(id);
        }
        public Category GetCategoryByName(string name)
        {
            return CategoryDAO.Instance.GetCategoryByName(name);
        }
        public void AddCategory(string name)
        {
            if (CategoryDAO.Instance.AddCategory(name))
            {
                MessageBox.Show("Add A Successful Category ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \nAdd failed category ");
            }
        }
        public void UpdateCategory(int idCategory, string namecategory)
        {
            if (CategoryDAO.Instance.UpdateCategory(idCategory, namecategory))
            {
                MessageBox.Show("Updating the list of successful Category ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \n Updating failed Category ");
            }
        }
        public void DelCategory(int idCategory)
        {

            if (CategoryDAO.Instance.DeleteCategory(idCategory))
            {
                MessageBox.Show("Delete the list of successful Category ");
            }
            else
            {
                MessageBox.Show("ERROR !!! \n Delete failed Category ");
            }
        }
        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = new List<Category>();
            listCategory = CategoryDAO.Instance.SearchCategoryByName(name);
            return listCategory;
        }
    }
}
