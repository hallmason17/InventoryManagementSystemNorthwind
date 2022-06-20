using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystemNorthwind
{
    public partial class InventoryAdjustment : Form
    {
        public InventoryAdjustment()
        {
            InitializeComponent();
            maskedTextBox1.Text = Globals.UserName;
        }

        private void InventoryAdjustment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productID = productIDBox.Text;
            string productName = productNameBox.Text;
            DataTable dataTable = new DataTable();


            string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            //Initial Search
            string sqlQuery = "SELECT * FROM Products WHERE ProductID LIKE @ProductID OR ProductName LIKE @ProductName";

            SqlCommand sc = new SqlCommand(sqlQuery, con);

            sc.Parameters.Add(new SqlParameter("@ProductID", productID));
            sc.Parameters.Add(new SqlParameter("@ProductName", productName));

            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productID = productIDBox.Text;
            string productName = productNameBox.Text;
            string unitsInStock = newUnitsInStockBox.Text;
            DataTable dataTable = new DataTable();


            string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            //Adjustment SP call
            SqlCommand cmd = new SqlCommand("Adjustment", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.Add(new SqlParameter("@ProductID", productID));
            cmd.Parameters.Add(new SqlParameter("@ProductName", productName));
            cmd.Parameters.Add(new SqlParameter("@UnitsInStock", unitsInStock));

            cmd.ExecuteNonQuery();

            //Post-Adjustment Search
            string sqlQuery1 = "SELECT * FROM Products WHERE ProductID LIKE @ProductID OR ProductName LIKE @ProductName";

            SqlCommand sc1 = new SqlCommand(sqlQuery1, con);

            sc1.Parameters.Add(new SqlParameter("@ProductID", productID));
            sc1.Parameters.Add(new SqlParameter("@ProductName", productName));

            SqlDataAdapter da1 = new SqlDataAdapter(sc1);
            da1.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sc1.ExecuteNonQuery();
            con.Close();
        }

    }
}
