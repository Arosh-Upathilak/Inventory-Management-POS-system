using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
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
    public partial class UserForm : Form
    {
        private readonly DBConnector _dBConnector;
        private readonly UserRepository _userRepository;
        public UserForm()
        {
            InitializeComponent();
            _dBConnector = new DBConnector();
            _userRepository = new UserRepository(_dBConnector);
            LoadUser();
        }
        public void LoadUser()
        {
            dgUser.Rows.Clear();
            int i = 1;
            var result = _userRepository.GetAllUsers();
            foreach (UserDto user in result){
                dgUser.Rows.Add(
                    i,
                    user.username,
                    user.fullname,
                    user.password,
                    user.phone
                );
                ++i;
            }
        }

        private void cbAddUser_Click(object sender, EventArgs e)
        {
            UserModuleForm userModuleForm = new UserModuleForm();
            userModuleForm.bSave.Enabled = true;
            userModuleForm.bUpdate.Enabled = false;
            userModuleForm.bClear.Enabled = true;
            userModuleForm.ShowDialog();
            LoadUser();
        }

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgUser.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                UserModuleForm userModuleForm = new UserModuleForm();
                userModuleForm.tbUserName.Text = dgUser.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                userModuleForm.tbFullName.Text = dgUser.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                userModuleForm.tbPassword.Text = dgUser.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                userModuleForm.tbPhone.Text = dgUser.Rows[e.RowIndex].Cells["Phone"].Value.ToString();

                userModuleForm.bSave.Enabled = false;
                userModuleForm.bUpdate.Enabled = true;
                userModuleForm.tbUserName.Enabled = false;
                userModuleForm.ShowDialog();
                LoadUser();
            }
            else if (colName == "Delete")
            {
                if(MessageBox.Show("Are you want to Delete this User","Delete User",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string userName = dgUser.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                    bool result = _userRepository.DeleteUser(userName);
                    if (result)
                    {
                        MessageBox.Show("Record has been sucessfyly deleted");
                        LoadUser();
                    }
                }
            }
        }
    }
}
