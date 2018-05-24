using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCRUD
{
    public partial class Login : Form
    {
        public static string loginName ;
        public Login()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_loginName.Text != "" && txt_password.Text != "")
            {
                if (txt_loginName.Text == "Admin" && txt_password.Text =="admin")
                {
                    loginName = txt_loginName.Text;
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Invalid 'login name' or 'password'!");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Your 'login name' & 'password' both!");
            }
        }
       
    }
}
