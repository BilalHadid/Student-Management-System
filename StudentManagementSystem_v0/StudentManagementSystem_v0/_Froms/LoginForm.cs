using StudentManagementSystem_v0._CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            
                
                
            
                try
                {
                    var login = new LoginFacade(txtUserName.text, txtPassword.text);
                    login.Login(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addUser = new AddUser();
            addUser.Show();
        }
    }
}
