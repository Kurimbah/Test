using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team7mockup
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(frmMain.email.Equals("0"))
            {
                mnuEmployees.Enabled = false;
                mnuEmployees.Visible = false;
                mnuManagers.Enabled = false;
                mnuManagers.Visible = false;
            }
            else if (frmMain.email.Equals("1"))
            {
                mnuManagers.Enabled = false;
                mnuManagers.Visible = false;
            }
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerOrder order = new frmCustomerOrder();
            order.ShowDialog();
        }

        private void viewOrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerHistory history = new frmCustomerHistory();
            history.ShowDialog();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeStock stock = new frmEmployeeStock();
            stock.ShowDialog();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeSchedule schedule = new frmEmployeeSchedule();
            schedule.ShowDialog();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerEmployees employeeDatabase = new frmManagerEmployees();
            employeeDatabase.ShowDialog();
        }

        private void manageSchedulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerSchedules scheduleManager = new frmManagerSchedules();
            scheduleManager.ShowDialog();
        }

        private void manageInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerInventory inventoryManager = new frmManagerInventory();
            inventoryManager.ShowDialog();
        }
    }
}
