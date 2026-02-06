using InventoryManagementSystem.Data;
using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly DBConnector _dbconnector;
        private readonly CategoryRepository _categoryRepository;
        public CategoryForm()
        {
            InitializeComponent();
            _dbconnector = new DBConnector();
            _categoryRepository = new CategoryRepository(_dbconnector);
            LoadCategory();
        }

        private void cbAddUser_Click(object sender, EventArgs e)
        {
            CategoryModuleForm categoriesModuleForm = new CategoryModuleForm();
            categoriesModuleForm.bCatogorySave.Enabled = true;
            categoriesModuleForm.bCatogoryUpdate.Enabled = false;
            categoriesModuleForm.bCatogoryClear.Enabled = true;
            categoriesModuleForm.ShowDialog();
            LoadCategory();
        }

        private void LoadCategory()
        {
            dgCatogory.Rows.Clear();
            int i = 1;
            var result = _categoryRepository.GetAllCategory();
            foreach (var category in result)
            {
                dgCatogory.Rows.Add(
                    i,
                    category.categoryId,
                    category.categoryname
                );
                ++i;
            }
        }

        private void dgCatogory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgCatogory.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm categoryModuleForm = new CategoryModuleForm();
                categoryModuleForm.categoryId.Text = dgCatogory.Rows[e.RowIndex].Cells["CategoryId"].Value.ToString();
                categoryModuleForm.tbCategoryName.Text = dgCatogory.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                categoryModuleForm.bCatogorySave.Enabled = false;
                categoryModuleForm.bCatogoryUpdate.Enabled = true;
                categoryModuleForm.bCatogoryClear.Enabled = true;
                categoryModuleForm.ShowDialog();
                LoadCategory();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you want to delete this record", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int categoryId = Convert.ToInt32(dgCatogory.Rows[e.RowIndex].Cells["CategoryId"].Value.ToString());
                    try
                    {
                        bool result = _categoryRepository.DeleteCategory(categoryId);
                        if (result)
                        {
                            MessageBox.Show("Catogory Delete Successfully");
                            LoadCategory();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
        }
    }
}
