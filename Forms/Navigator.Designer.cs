
namespace InventoryManagementSystemNorthwind
{
    partial class Navigator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InventoryButton = new System.Windows.Forms.Button();
            this.ReceiveNewButton = new System.Windows.Forms.Button();
            this.AdjustInventoryButton = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InventoryButton
            // 
            this.InventoryButton.Location = new System.Drawing.Point(102, 51);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(160, 48);
            this.InventoryButton.TabIndex = 0;
            this.InventoryButton.Text = "Inventory Query";
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // ReceiveNewButton
            // 
            this.ReceiveNewButton.Location = new System.Drawing.Point(102, 105);
            this.ReceiveNewButton.Name = "ReceiveNewButton";
            this.ReceiveNewButton.Size = new System.Drawing.Size(160, 48);
            this.ReceiveNewButton.TabIndex = 1;
            this.ReceiveNewButton.Text = "Receive New Item";
            this.ReceiveNewButton.UseVisualStyleBackColor = true;
            this.ReceiveNewButton.Click += new System.EventHandler(this.ReceiveNewButton_Click);
            // 
            // AdjustInventoryButton
            // 
            this.AdjustInventoryButton.Location = new System.Drawing.Point(102, 159);
            this.AdjustInventoryButton.Name = "AdjustInventoryButton";
            this.AdjustInventoryButton.Size = new System.Drawing.Size(160, 48);
            this.AdjustInventoryButton.TabIndex = 2;
            this.AdjustInventoryButton.Text = "Adjust Inventory";
            this.AdjustInventoryButton.UseVisualStyleBackColor = true;
            this.AdjustInventoryButton.Click += new System.EventHandler(this.AdjustInventoryButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Location = new System.Drawing.Point(413, 15);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logged In As:";
            // 
            // Navigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(507, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.AdjustInventoryButton);
            this.Controls.Add(this.ReceiveNewButton);
            this.Controls.Add(this.InventoryButton);
            this.Name = "Navigator";
            this.Text = "Navigator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Navigator_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button ReceiveNewButton;
        private System.Windows.Forms.Button AdjustInventoryButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}