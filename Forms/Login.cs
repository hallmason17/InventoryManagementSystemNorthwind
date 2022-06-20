using InventoryManagementSystemNorthwind.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace InventoryManagementSystemNorthwind
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {
            _ = new Globals();
            Globals.UserName = UserNameBox.Text;

            Logic.LoginLogicClick(UserNameBox.Text, PasswordBox.Text, e, this);
        }
        private void PasswordBox_KeyPress(object sender, KeyEventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            _ = new Globals();
            Globals.UserName = UserNameBox.Text;

            Logic.LoginLogicKey(UserNameBox.Text,PasswordBox.Text,e,this);
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}
