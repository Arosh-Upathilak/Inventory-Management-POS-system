using InventoryManagementSystem.Data;
using InventoryManagementSystem.Dtos;
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
    public partial class CategoryModuleForm : Form
    {
        private readonly DBConnector _dbConnector;
        private readonly CategoryRepository _categoryRepository;
        public CategoryModuleForm()
        {
            InitializeComponent();
            _dbConnector = new DBConnector();
            _categoryRepository = new CategoryRepository(_dbConnector);
        }

        private void bCustomerClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearTextBox()
        {
            tbCategoryName.Clear();
        }

        private void bCatogorySave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCategoryName.Text))
            {
                MessageBox.Show("All feild must be filed", "Error", MessageBoxButtons.OKCancel);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to create this category", "Create Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CategoryDto categoryDto = new CategoryDto()
                    {
                        categoryname = tbCategoryName.Text.Trim(),
                    };
                    _categoryRepository.CreateCategory(categoryDto);
                    MessageBox.Show("Category Create Successfull", "Success");
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bCatogoryUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCategoryName.Text))
            {
                MessageBox.Show("All feild required", "Error");
                return;
            }
            try
            {
                if (MessageBox.Show("Are you want to update this record", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CategoryDto categoryDto = new CategoryDto()
                    {
                        categoryId = Convert.ToInt32(categoryId.Text.Trim()),
                        categoryname = tbCategoryName.Text.Trim(),
                    };
                    bool result = _categoryRepository.UpdateCategory(categoryDto);
                    if (result)
                    {
                        MessageBox.Show("Category Update Succesfully");
                        ClearTextBox();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Category Update Failed becaurse of User does not Exits", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
