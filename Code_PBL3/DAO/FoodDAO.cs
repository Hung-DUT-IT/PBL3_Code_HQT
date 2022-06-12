﻿using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_PBL3.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where IsDeleted = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListFoodByCategory(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idFoodCategory = " + id + " and IsDeleted = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public Food GetFoodByName(string name)
        {
            string query = "select * from Food where Name = '" + name + "' and IsDeleted = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return  new Food(item);
            }
            return null; 
        }
        public bool AddFood(string name, int idcategory, int price)
        {
            string query = String.Format("insert into Food values ({0},'{1}',{2})", idcategory, name, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(int idfood,int idcate, string name, int price)
        {

            string query = String.Format("update Food set Name = '{0}', IdFoodCategory = {1} , Price = {2}  where IdFood = {3} ", name, idcate, price, idfood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            string query = String.Format("Update Food set IsDeleted = 1 where IdFood = {0}", id);
              int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Food> SearchAccountByName(string Name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from Food where dbo.GetUnsignString(Name) like '%'+ dbo.GetUnsignString('{0}') + '%'", Name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
    }
}
