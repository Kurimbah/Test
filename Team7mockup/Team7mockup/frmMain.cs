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
    public partial class frmMain : Form
    {
        public static string email;
        public static string pw;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            email = tbxEmail.Text;
            pw = tbxPassword.Text;

            frmMenu customForm = new frmMenu();

            customForm.ShowDialog();
            
        }
    }
}
