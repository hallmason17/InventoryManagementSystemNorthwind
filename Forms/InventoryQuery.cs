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
    public partial class InventoryQuery : Form
    {

        public InventoryQuery()
        {
            InitializeComponent();
            maskedTextBox1.Text = Globals.UserName;
        }

        private void ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        { 
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            string connectionString = "Data Source=DESKTOP-TGGGHB1;Initial Catalog=Northwind;Integrated Security=True";

            if (productIDBox.Text == "")
            {
                productIDBox.Text = "'%'";
            }
            if (productNameBox.Text == "")
            {
                productNameBox.Text = "'%'";
            }
            if (supplierIDBox.Text == "")
            {
                supplierIDBox.Text = "'%'";
            }
            if (categoryIDBox.Text == "")
            {
                categoryIDBox.Text = "'%'";
            }
            if (quantityPerUnitBox.Text == "")
            {
                quantityPerUnitBox.Text = "'%'";
            }
            if (unitPriceBox.Text == "")
            {
                unitPriceBox.Text = "'%'";
            }
            if (unitsInStockBox.Text == "")
            {
                unitsInStockBox.Text = "'%'";
            }
            if (unitsOnOrderBox.Text == "")
            {
                unitsOnOrderBox.Text = "'%'";
            }
            if (reOrderLevelBox.Text == "")
            {
                reOrderLevelBox.Text = "'%'";
            }
            if (discontinuedBox.Text == "")
            {
                discontinuedBox.Text = "'%'";
            }
            string sqlQuery = "SELECT * FROM Products WHERE ProductID LIKE " + productIDBox.Text + " AND ProductName LIKE " + productNameBox.Text + " AND SupplierID LIKE " + supplierIDBox.Text + " AND CategoryID LIKE " + categoryIDBox.Text + " AND QuantityPerUnit LIKE " + quantityPerUnitBox.Text + " AND UnitPrice LIKE " + unitPriceBox.Text + " AND UnitsInStock LIKE " + unitsInStockBox.Text + " AND UnitsOnOrder LIKE " + unitsOnOrderBox.Text + " AND ReorderLevel LIKE " + reOrderLevelBox.Text + "AND Discontinued LIKE " + discontinuedBox.Text + "";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sc.ExecuteNonQuery();
            con.Close();

            if (productIDBox.Text == "'%'")
            {
                productIDBox.Text = "";
            }
            if (productNameBox.Text == "'%'")
            {
                productNameBox.Text = "";
            }
            if (supplierIDBox.Text == "'%'")
            {
                supplierIDBox.Text = "";
            }
            if (categoryIDBox.Text == "'%'")
            {
                categoryIDBox.Text = "";
            }
            if (quantityPerUnitBox.Text == "'%'")
            {
                quantityPerUnitBox.Text = "";
            }
            if (unitPriceBox.Text == "'%'")
            {
                unitPriceBox.Text = "";
            }
            if (unitsInStockBox.Text == "'%'")
            {
                unitsInStockBox.Text = "";
            }
            if (unitsOnOrderBox.Text == "'%'")
            {
                unitsOnOrderBox.Text = "";
            }
            if (reOrderLevelBox.Text == "'%'")
            {
                reOrderLevelBox.Text = "";
            }
            if (discontinuedBox.Text == "'%'")
            {
                discontinuedBox.Text = "";
            }

        }
    }
}
