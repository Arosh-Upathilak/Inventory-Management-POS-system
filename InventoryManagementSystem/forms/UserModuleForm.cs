using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class UserModuleForm : Form
    {
        private readonly DBConnector _connector;
        private readonly UserRepository _repository;

        public UserModuleForm()
        {
            InitializeComponent();
            _connector = new DBConnector();
            _repository = new UserRepository(_connector);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tbRetypePassword.Text != tbPassword.Text)
                    {
                        MessageBox.Show("Password Not Match", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(tbUserName.Text.Trim()) || string.IsNullOrEmpty(tbFullName.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()) || string.IsNullOrEmpty(tbPhone.Text.Trim()))
                    {
                        MessageBox.Show("All field required", "Error", MessageBoxButtons.OKCancel);
                        ClearTextBox();
                        return;
                    }
                    
                    UserDto user = new UserDto
                    {
                        username = tbUserName.Text.Trim(),
                        fullname = tbFullName.Text.Trim(),
                        password = tbPassword.Text.Trim(),
                        phone = tbPhone.Text.Trim()
                    };

                    _repository.CreateUser(user);

                    MessageBox.Show("User saved successfully!", "Success");

                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ClearTextBox()
        {
            tbUserName.Clear();
            tbFullName.Clear();
            tbPassword.Clear();
            tbPhone.Clear();
            tbRetypePassword.Clear();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to update thois user", "Update User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tbRetypePassword.Text != tbPassword.Text)
                    {
                        MessageBox.Show("Password Not Match", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrEmpty(tbUserName.Text.Trim()) || string.IsNullOrEmpty(tbFullName.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()) || string.IsNullOrEmpty(tbPhone.Text.Trim()))
                    {
                        MessageBox.Show("All field required", "Error", MessageBoxButtons.OKCancel);
                        ClearTextBox();
                        return;
                    }

                    UserDto updateUser = new UserDto
                    {
                        username = tbUserName.Text.Trim(),
                        fullname = tbFullName.Text.Trim(),
                        password = tbPassword.Text.Trim(),
                        phone = tbPhone.Text.Trim()
                    };

                    bool result = _repository.UpdateUser(updateUser);
                    if (result)
                    {
                        MessageBox.Show("User Update Successfully");
                        ClearTextBox();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("User Update Failed.");
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
