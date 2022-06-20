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
    public partial class Receive : Form
    {
        public Receive()
        {
            InitializeComponent();
            maskedTextBox1.Text = Globals.UserName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("Receiving", con);
            cmd.CommandType = CommandType.StoredProcedure;

            string productName = productNameBox.Text;
            string supplierID = supplierIDBox.Text;
            string categoryID = categoryIDBox.Text;
            string quantityPerUnit = quantityPerUnitBox.Text;
            string unitPrice = unitPriceBox.Text;
            string unitsInStock = unitsInStockBox.Text;
            string unitsOnOrder = unitsOnOrderBox.Text;
            string reOrderLevel = reOrderLevelBox.Text;
            string discontinued = discontinuedBox.Text;

            cmd.Parameters.Add(new SqlParameter("@ProductName", productName));
            cmd.Parameters.Add(new SqlParameter("@SupplierID", supplierID));
            cmd.Parameters.Add(new SqlParameter("@CategoryID", categoryID));
            cmd.Parameters.Add(new SqlParameter("@QuantityPerUnit", quantityPerUnit));
            cmd.Parameters.Add(new SqlParameter("@UnitPrice", unitPrice));
            cmd.Parameters.Add(new SqlParameter("@UnitsInStock", unitsInStock));
            cmd.Parameters.Add(new SqlParameter("@UnitsOnOrder", unitsOnOrder));
            cmd.Parameters.Add(new SqlParameter("@ReorderLevel", reOrderLevel));
            cmd.Parameters.Add(new SqlParameter("@Discontinued", discontinued));

            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
