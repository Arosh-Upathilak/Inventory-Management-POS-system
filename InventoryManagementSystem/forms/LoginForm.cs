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
    public partial class LoginForm : Form
    {
        private readonly DBConnector _dBConnector;
        private readonly UserRepository _userRepository;
        public LoginForm()
        {
            InitializeComponent();
            _dBConnector = new DBConnector();
            _userRepository = new UserRepository(_dBConnector);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked == false)
            {
                tUserPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tUserPassword.UseSystemPasswordChar = false;
            }
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            tUserPassword.Clear();
            tUserName.Clear();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application","Confirm",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string result = _userRepository.LoginUser(tUserName.Text, tUserPassword.Text);
                if(result != null)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(result);
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tUserPassword.Clear();
                    tUserName.Clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                tUserPassword.Clear();
                tUserName.Clear();
            }
        }
    }
}
