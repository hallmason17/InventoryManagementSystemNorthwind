using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemNorthwind
{
    public partial class Navigator : Form
    {
        public Navigator()
        {
            InitializeComponent();
            maskedTextBox1.Text = Globals.UserName;
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryQuery iv = new InventoryQuery();
            iv.ShowDialog();
        }

        private void ReceiveNewButton_Click(object sender, EventArgs e)
        {
            Receive rcv = new Receive();
            rcv.ShowDialog();
        }

        private void AdjustInventoryButton_Click(object sender, EventArgs e)
        {
            InventoryAdjustment ia = new InventoryAdjustment();
            ia.ShowDialog();
        }

        private void Navigator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
