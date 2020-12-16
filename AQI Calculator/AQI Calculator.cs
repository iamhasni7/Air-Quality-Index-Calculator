using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQI_Calculator
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnPunjabaqi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnPunjabaqi.Checked)
            {
               

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 0x6E)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a number");
            }
        }
    }
}

 
