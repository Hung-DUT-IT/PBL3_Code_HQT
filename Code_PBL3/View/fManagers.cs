using Code_PBL3.BUS;
using Code_PBL3.DAO;
using Code_PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_PBL3
{
    public partial class fManagers : Form
    {
        BindingSource AccountList = new BindingSource();
        BindingSource StaffList = new BindingSource();
        BindingSource CategoryList = new BindingSource();
        BindingSource FoodList = new BindingSource();
        BindingSource TableList = new BindingSource();
        BindingSource AreaList = new BindingSource();
        BindingSource CusList = new BindingSource();
        private int idAcc;
        public int IdAcc
        {
            get { return idAcc; }
            set { idAcc = value; }
        }
            
        public fManagers(int idAcc)
        {
            InitializeComponent();
            this.IdAcc = idAcc;
            LoadDGV();
            LoadListBinding();
            Binding(); 
        }
        #region Method
        void LoadListBinding()
        {
            LoadAccount();
            LoadStaff();
            LoadCategory();
            LoadFood();
            LoadTable();
            LoadArea();
            LoadCus();
            LoadCbbCate();
            LoadCBBAreaTableFood();
            LoadCBBIsDeleteTable();
        }
        void LoadDGV()
        {
            dgvStaff.DataSource = StaffList;         
            dgvAcount.DataSource = AccountList;
            dgvCategory.DataSource = CategoryList;
            dgvFood.DataSource = FoodList;
            dgvTable.DataSource = TableList;
            dgvArea.DataSource = AreaList;
            dgvCus.DataSource = CusList;
        }
        void Binding()
        {
            AddAccountBiding();
            AddStaffBiding();
            AddCategoryBiding();
            AddFoodBiding();
            AddTableBiding();
            AddAreaBiding();
            AddCusBiding();
        }
        void LoadAccount()
        {
            AccountList.DataSource = AccountBUS.Instance.LoadAccount();
            dgvAcount.Columns[0].HeaderText = "Account code";
            dgvAcount.Columns[1].HeaderText = "Employee Code";
            dgvAcount.Columns[2].HeaderText = "User Name";
            dgvAcount.Columns[3].HeaderText = "Display Name";
            dgvAcount.Columns[4].HeaderText = "Password";
            dgvAcount.Columns[5].HeaderText = "Account Type";
            dgvAcount.Columns[6].Visible = false;
        }
        void LoadStaff()
        {
            StaffList.DataSource = StaffBUS.Instance.LoadStaff();
            dgvStaff.Columns[0].HeaderText = "Employee Code";
            dgvStaff.Columns[1].HeaderText = "Position";
            dgvStaff.Columns[2].HeaderText = "Name";
            dgvStaff.Columns[3].HeaderText = "Phone";
            dgvStaff.Columns[4].HeaderText = "Shift";
            dgvStaff.Columns[5].Visible = false;
        }
        void LoadCategory()
        {
            CategoryList.DataSource = CategoryBUS.Instance.GetListCategory();
            dgvCategory.Columns[0].HeaderText = "Category Code";
            dgvCategory.Columns[1].HeaderText = "Category Name ";
            dgvCategory.Columns[2].Visible = false;
        }
        void LoadFood()
        {
            FoodList.DataSource = FoodBUS.Instance.GetListFood();
            dgvFood.Columns[0].HeaderText = "Food Code";
            dgvFood.Columns[1].HeaderText = "Food Name";
            dgvFood.Columns[2].HeaderText = "Category Code";
            dgvFood.Columns[3].HeaderText = "Price";
            dgvFood.Columns[4].Visible = false;
        }
        void LoadTable()
        {
            TableList.DataSource = TableFoodBUS.Instance.LoadTableList();
            dgvTable.Columns[0].HeaderText = "Table Code";
            dgvTable.Columns[1].HeaderText = "Table Name";
            dgvTable.Columns[2].HeaderText = "Area Code";
            dgvTable.Columns[3].HeaderText = "Status";
            dgvTable.Columns[4].Visible = false;
        }
        void LoadArea()
        {
            AreaList.DataSource = AreaBUS.Instance.LoadAreaList();
            dgvArea.Columns[0].HeaderText = "Area Code";
            dgvArea.Columns[1].HeaderText = "Area Name";
            dgvArea.Columns[2].Visible = false;
        }
        void LoadCus()
        {
            CusList.DataSource = CustomerBUS.Instance.GetListCus();
            dgvCus.Columns[0].HeaderText = "Customer Code";
            dgvCus.Columns[1].HeaderText = "Customer Name";
            dgvCus.Columns[1].HeaderText = "Phone Name";
            dgvCus.Columns[1].HeaderText = "Point Name";
            dgvCus.Columns[4].Visible = false;
        }
        void LoadCbbCate()
        {
            cbbNameCategory.Items.Clear();
            cbbNameCategory.DataSource = CategoryBUS.Instance.GetListCategory();
            cbbNameCategory.DisplayMember = "NameCategory";
        }
        void LoadCBBAreaTableFood()
        {
            cbbArea.DataSource = AreaBUS.Instance.LoadAreaList();
            cbbArea.DisplayMember = "NameArea";          
        }
        void LoadCBBIsDeleteTable()
        {
            cbbIsDelete.Items.Clear();
            cbbIsDelete.Items.Add("Đã Xóa");
            cbbIsDelete.Items.Add("Chưa Xóa");
            cbbIsDelete.SelectedIndex = 1;
        }
        #endregion
        #region AddBinding
        void AddAccountBiding()
        {
            txbIdAccount.DataBindings.Add(new Binding("Text", dgvAcount.DataSource, "IdAccount", true, DataSourceUpdateMode.Never));
            txbIDStaffInAc.DataBindings.Add(new Binding("Text", dgvAcount.DataSource, "IdStaff", true, DataSourceUpdateMode.Never));
            txbUserName.DataBindings.Add(new Binding("Text", dgvAcount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbPass.DataBindings.Add(new Binding("Text", dgvAcount.DataSource, "PassWord", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dgvAcount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dgvAcount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }                  
        void AddStaffBiding()
        {
            txbidStaff.DataBindings.Add(new Binding("Text", dgvStaff.DataSource, "IdStaff", true, DataSourceUpdateMode.Never));
            txbPositionStaff.DataBindings.Add(new Binding("Text", dgvStaff.DataSource, "Position", true, DataSourceUpdateMode.Never));
            txbNameStaff.DataBindings.Add(new Binding("Text", dgvStaff.DataSource, "NameStaff", true, DataSourceUpdateMode.Never));
            txbPhoneStaff.DataBindings.Add(new Binding("Text", dgvStaff.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txbShiftStaff.DataBindings.Add(new Binding("Text", dgvStaff.DataSource, "Shift", true, DataSourceUpdateMode.Never));
        }
       
        void AddCategoryBiding()
        {
            txbIDCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "IDCategory", true, DataSourceUpdateMode.Never));
            txtNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "NameCategory", true, DataSourceUpdateMode.Never));
        }
        void AddFoodBiding()
        {
            txbIDFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "IdFood", true, DataSourceUpdateMode.Never));
            txbNameFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "NameFood", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "PriceFood", true, DataSourceUpdateMode.Never));          
        }
        void AddTableBiding()
        {
            txbIdTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "IdTable", true, DataSourceUpdateMode.Never));
            txbNameTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "NameTable", true, DataSourceUpdateMode.Never));
            txbStatusTable.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void AddAreaBiding()
        {
            txbIdArea.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "IdArea", true, DataSourceUpdateMode.Never));
            txbNameArea.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "NameArea", true, DataSourceUpdateMode.Never));
        }
        void AddCusBiding()
        {
            txbIDCus.DataBindings.Add(new Binding("Text", dgvCus.DataSource, "IdCus", true, DataSourceUpdateMode.Never));
            txbNameCus.DataBindings.Add(new Binding("Text", dgvCus.DataSource, "NameCus", true, DataSourceUpdateMode.Never));
            txbPhoneCus.DataBindings.Add(new Binding("Text", dgvCus.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            txbPointCus.DataBindings.Add(new Binding("Text", dgvCus.DataSource, "Point", true, DataSourceUpdateMode.Never));
        }
        #endregion
        #region Events TabAccount
        private void btShow_Click_1(object sender, EventArgs e)
        {
            AccountList.DataSource = AccountBUS.Instance.LoadAccount();
        }

        private void btAddAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                string userName = txbUserName.Text;
                string pass = txbPass.Text;
                string displayName = txbDisplayName.Text;
                int type = (int)nmTypeAccount.Value;
                AccountBUS.Instance.AddAccount(userName, displayName, type, pass);
                LoadAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUpdateAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                string userName = txbUserName.Text;
                int type = (int)nmTypeAccount.Value;
                AccountBUS.Instance.UpadateAccount(userName, type);
                LoadAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btDelAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idAcc = Convert.ToInt32(dgvAcount.SelectedRows[0].Cells["IdAccount"].Value);
                if (this.IdAcc.Equals(idAcc))
                {
                    MessageBox.Show("********* This is you can't delete this account *********");
                    return;
                }
                else
                {
                    int idac = Convert.ToInt32(txbIdAccount.Text);
                    AccountBUS.Instance.DeleteAccount(idac);
                }
                LoadAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void btSearhAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(txbSearchAcount.Text != "" && txbSearchAcount.Text != null )
                {
                    AccountList.DataSource = AccountBUS.Instance.SearchAccByUserName(txbSearchAcount.Text);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Events TabStaff
        private void bntAddStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = txbNameStaff.Text;
                string phone = txbPhoneStaff.Text;
                string position = txbPositionStaff.Text;
                string shift = txbShiftStaff.Text;
                StaffBUS.Instance.AddStaff(name, phone, position, shift);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idStaff = Convert.ToInt32(txbidStaff.Text);
                string userName = txbNameStaff.Text;
                string Position = txbPositionStaff.Text;
                string Shift = txbShiftStaff.Text;
                StaffBUS.Instance.UpdateStaffByAdmin(idStaff, userName, Position, Shift);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btDelStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idstaff = Convert.ToInt32(txbidStaff.Text);
                StaffBUS.Instance.DelStafff(idstaff);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void bntShow_Click_1(object sender, EventArgs e)
        {
            StaffList.DataSource = StaffBUS.Instance.LoadStaff();
        }

        private void bntSearchStaff_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbsearchStaff.Text != "" && txbsearchStaff.Text != null)
                {
                    StaffList.DataSource = StaffBUS.Instance.SearchStaffByName(txbsearchStaff.Text);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
        }
        #endregion
        #region Events TabCategory
        private void btAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNameCategory.Text;
                CategoryBUS.Instance.AddCategory(name);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void btUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int idcategory = Convert.ToInt32(txbIDCategory.Text);
                string name = txtNameCategory.Text;
                CategoryBUS.Instance.UpdateCategory(idcategory, name);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int idcategory = Convert.ToInt32(txbIDCategory.Text);
                CategoryBUS.Instance.DelCategory(idcategory);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnSearchCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbSearchCategory.Text != "" && txbSearchCategory.Text != null)
                {
                    string name = txbSearchCategory.Text;
                    CategoryList.DataSource = CategoryBUS.Instance.SearchCategoryByName(name);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btShowCategory_Click(object sender, EventArgs e)
        {
            CategoryList.DataSource = CategoryBUS.Instance.GetListCategory();
        }
        #endregion
        #region Events TabFood
        private void btAddFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = txbNameFood.Text;
                int categoryiD = (cbbNameCategory.SelectedItem as Category).IDCategory;
                int price = Convert.ToInt32(nmFoodPrice.Value);
                FoodBUS.Instance.AddFood(name, categoryiD, price);
                LoadFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btUpdateFood_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idfood = Convert.ToInt32(txbIDFood.Text);
                string name = txbNameFood.Text;
                int price = Convert.ToInt32(nmFoodPrice.Value);
                int categoryiD = (cbbNameCategory.SelectedItem as Category).IDCategory;
                FoodBUS.Instance.UpdateFood(idfood, categoryiD, name, price);
                LoadFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btDeleteFod_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idfood = Convert.ToInt32(txbIDFood.Text);
                FoodBUS.Instance.DelFood(idfood);
                LoadFood();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btSearchF_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbSearchFood.Text != "" && txbSearchFood.Text != null)
                {
                    string name = txbSearchFood.Text;
                    FoodList.DataSource = FoodBUS.Instance.SearchAccByName(name);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            FoodList.DataSource = FoodBUS.Instance.GetListFood();
        }
        #endregion
        #region Events TabTable
        private void btAddTable_Click(object sender, EventArgs e)
        {
            int idArea = (cbbArea.SelectedItem as Area).IDArea;
            string name = txbNameTable.Text;
            string status = txbStatusTable.Text;
            TableFoodBUS.Instance.AddTable(idArea, name);
            LoadTable();
            /*try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
        }

        private void btUpdateTable_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(txbIdTable.Text);
                int idArea = (cbbArea.SelectedItem as Area).IDArea;
                string name = txbNameTable.Text;
                string status = txbStatusTable.Text;
                int isdelete;
                if (cbbIsDelete.SelectedIndex == 0)
                {
                    isdelete = 1;
                }
                else
                {
                    isdelete = 0;
                }
                TableFoodBUS.Instance.UpdateTable(idTable, idArea, name, status, isdelete);
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = Convert.ToInt32(txbIdTable.Text);
                TableFoodBUS.Instance.DelTable(idTable);
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbSearchTable.Text != "" && txbSearchTable.Text != null)
                {
                    string name = txbSearchTable.Text;
                    TableList.DataSource = TableFoodBUS.Instance.SearchTableByName(name);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btShowTable_Click(object sender, EventArgs e)
        {
            TableList.DataSource = TableFoodBUS.Instance.LoadTableList();
        }
        #endregion
        #region Events TabArea
        private void btAddArea_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txbNameArea.Text;
                AreaBUS.Instance.AddArea(name);
                LoadArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btUpdateArea_Click(object sender, EventArgs e)
        {
            try
            {
                int idArea = Convert.ToInt32(txbIdArea.Text);
                string name = txbNameArea.Text;
                AreaBUS.Instance.UpdateArea(idArea, name);
                LoadArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btDeleteArea_Click(object sender, EventArgs e)
        {
            try
            {
                int idArea = Convert.ToInt32(txbIdArea.Text);
                AreaBUS.Instance.DelArea(idArea);
                LoadArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearchArea_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbSearchArea.Text != "" && txbSearchArea.Text != null)
                {
                    string name = txbSearchArea.Text;
                    AreaList.DataSource = AreaBUS.Instance.SearchAreayName(name);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AreaList.DataSource = AreaBUS.Instance.LoadAreaList();
        }

        #endregion
        #region Events TabCus
        private void button3_Click(object sender, EventArgs e)
        {
            CusList.DataSource = CustomerBUS.Instance.GetListCus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbSearchCus.Text != "" && txbSearchCus.Text != null)
                {
                    CusList.DataSource = CustomerBUS.Instance.SearchCusByName(txbSearchCus.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Vui Lòng Giá Trị Tìm Kiếm !!");
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
