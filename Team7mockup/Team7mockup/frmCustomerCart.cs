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
    public partial class frmCustomerCart : Form
    {
        public frmCustomerCart()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReceipt receipt = new frmReceipt();
            receipt.ShowDialog();
        }
    }
}
