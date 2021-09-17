
namespace Team7mockup
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemManageEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemManageSchedules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemManageInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbxMainImage = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOrder,
            this.mnuEmployees,
            this.mnuManagers});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(588, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(180, 22);
            this.mnuItemExit.Text = "Exit";
            // 
            // mnuOrder
            // 
            this.mnuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemCreate,
            this.mnuItemViewOrder});
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(49, 20);
            this.mnuOrder.Text = "Order";
            // 
            // mnuItemCreate
            // 
            this.mnuItemCreate.Name = "mnuItemCreate";
            this.mnuItemCreate.Size = new System.Drawing.Size(180, 22);
            this.mnuItemCreate.Text = "Create Order";
            this.mnuItemCreate.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // mnuItemViewOrder
            // 
            this.mnuItemViewOrder.Name = "mnuItemViewOrder";
            this.mnuItemViewOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuItemViewOrder.Text = "View Order History";
            this.mnuItemViewOrder.Click += new System.EventHandler(this.viewOrderHistoryToolStripMenuItem_Click);
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemViewStock,
            this.mnuItemViewSchedule});
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(76, 20);
            this.mnuEmployees.Text = "Employees";
            // 
            // mnuItemViewStock
            // 
            this.mnuItemViewStock.Name = "mnuItemViewStock";
            this.mnuItemViewStock.Size = new System.Drawing.Size(180, 22);
            this.mnuItemViewStock.Text = "View Stock";
            this.mnuItemViewStock.Click += new System.EventHandler(this.viewInventoryToolStripMenuItem_Click);
            // 
            // mnuItemViewSchedule
            // 
            this.mnuItemViewSchedule.Name = "mnuItemViewSchedule";
            this.mnuItemViewSchedule.Size = new System.Drawing.Size(180, 22);
            this.mnuItemViewSchedule.Text = "View Schedule";
            this.mnuItemViewSchedule.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // mnuManagers
            // 
            this.mnuManagers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemManageEmployees,
            this.mnuItemManageSchedules,
            this.mnuItemManageInventory});
            this.mnuManagers.Name = "mnuManagers";
            this.mnuManagers.Size = new System.Drawing.Size(71, 20);
            this.mnuManagers.Text = "Managers";
            // 
            // mnuItemManageEmployees
            // 
            this.mnuItemManageEmployees.Name = "mnuItemManageEmployees";
            this.mnuItemManageEmployees.Size = new System.Drawing.Size(180, 22);
            this.mnuItemManageEmployees.Text = "Manage Employees";
            this.mnuItemManageEmployees.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // mnuItemManageSchedules
            // 
            this.mnuItemManageSchedules.Name = "mnuItemManageSchedules";
            this.mnuItemManageSchedules.Size = new System.Drawing.Size(180, 22);
            this.mnuItemManageSchedules.Text = "Manage Schedules";
            this.mnuItemManageSchedules.Click += new System.EventHandler(this.manageSchedulesToolStripMenuItem_Click);
            // 
            // mnuItemManageInventory
            // 
            this.mnuItemManageInventory.Name = "mnuItemManageInventory";
            this.mnuItemManageInventory.Size = new System.Drawing.Size(180, 22);
            this.mnuItemManageInventory.Text = "Manage Inventory";
            this.mnuItemManageInventory.Click += new System.EventHandler(this.manageInventoryToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(176, 88);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(240, 99);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to 7 Pizzas Pizzaria!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxMainImage
            // 
            this.pbxMainImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxMainImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMainImage.BackgroundImage")));
            this.pbxMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMainImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxMainImage.Image")));
            this.pbxMainImage.Location = new System.Drawing.Point(182, 211);
            this.pbxMainImage.Name = "pbxMainImage";
            this.pbxMainImage.Size = new System.Drawing.Size(223, 174);
            this.pbxMainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMainImage.TabIndex = 2;
            this.pbxMainImage.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 397);
            this.Controls.Add(this.pbxMainImage);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7 Pizzas";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewStock;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuManagers;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageSchedules;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageInventory;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbxMainImage;
    }
}