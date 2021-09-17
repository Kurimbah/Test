
namespace Team7mockup
{
    partial class frmCustomerCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerCart));
            this.lbxCustomerItems = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShopping = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblSubtotalOutput = new System.Windows.Forms.Label();
            this.lblTaxOutput = new System.Windows.Forms.Label();
            this.lblGrandTotalOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCustomerItems
            // 
            this.lbxCustomerItems.FormattingEnabled = true;
            this.lbxCustomerItems.ItemHeight = 18;
            this.lbxCustomerItems.Location = new System.Drawing.Point(12, 12);
            this.lbxCustomerItems.Name = "lbxCustomerItems";
            this.lbxCustomerItems.Size = new System.Drawing.Size(357, 166);
            this.lbxCustomerItems.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 49);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 258);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 49);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnShopping
            // 
            this.btnShopping.Location = new System.Drawing.Point(12, 319);
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(96, 49);
            this.btnShopping.TabIndex = 4;
            this.btnShopping.Text = "Continue Shopping";
            this.btnShopping.UseVisualStyleBackColor = true;
            this.btnShopping.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(273, 319);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(96, 49);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Location = new System.Drawing.Point(143, 197);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(121, 22);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Location = new System.Drawing.Point(143, 234);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(121, 22);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax:";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Location = new System.Drawing.Point(143, 267);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(121, 22);
            this.lblGrandTotal.TabIndex = 8;
            this.lblGrandTotal.Text = "Grand Total:";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalOutput
            // 
            this.lblSubtotalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotalOutput.Location = new System.Drawing.Point(281, 197);
            this.lblSubtotalOutput.Name = "lblSubtotalOutput";
            this.lblSubtotalOutput.Size = new System.Drawing.Size(88, 22);
            this.lblSubtotalOutput.TabIndex = 9;
            this.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxOutput
            // 
            this.lblTaxOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxOutput.Location = new System.Drawing.Point(281, 234);
            this.lblTaxOutput.Name = "lblTaxOutput";
            this.lblTaxOutput.Size = new System.Drawing.Size(88, 22);
            this.lblTaxOutput.TabIndex = 10;
            this.lblTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotalOutput
            // 
            this.lblGrandTotalOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lblGrandTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotalOutput.Location = new System.Drawing.Point(281, 267);
            this.lblGrandTotalOutput.Name = "lblGrandTotalOutput";
            this.lblGrandTotalOutput.Size = new System.Drawing.Size(88, 22);
            this.lblGrandTotalOutput.TabIndex = 11;
            this.lblGrandTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCustomerCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team7mockup.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 380);
            this.Controls.Add(this.lblGrandTotalOutput);
            this.Controls.Add(this.lblTaxOutput);
            this.Controls.Add(this.lblSubtotalOutput);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnShopping);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbxCustomerItems);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCustomerCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Pizzas: Cart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCustomerItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShopping;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblSubtotalOutput;
        private System.Windows.Forms.Label lblTaxOutput;
        private System.Windows.Forms.Label lblGrandTotalOutput;
    }
}