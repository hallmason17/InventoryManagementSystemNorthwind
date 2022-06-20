using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace InventoryManagementSystemNorthwind.BL
{
    internal static class Logic
    {
        public static string LoginLogicKey(string username, string password, KeyEventArgs e, Login login)
        //Logic for logging in by hitting a key
        {
            _ = new Globals();
            Globals.UserName = username;


            if (e.KeyValue == (char)Keys.Enter)
            {
                if (password != string.Empty || username != string.Empty)
                {
                    string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + username + "' and password='" + password + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        login.Hide();
                        con.Close();
                        Navigator nav = new Navigator();
                        nav.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        con.Close();
                        MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }
        public static string LoginLogicClick(string username, string password, EventArgs e, Login login)
        //Logic for logging in by clicking
        {
            _ = new Globals();
            Globals.UserName = username;

            if (password != string.Empty || username != string.Empty)
            {
                string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + username + "' and password='" + password + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    login.Hide();
                    con.Close();
                    Navigator nav = new Navigator();
                    nav.ShowDialog();
                }
                else
                {
                    dr.Close();
                    con.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}