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
        string pm10 = "PM10";



        public frmMain()
        {
            InitializeComponent();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnPunjabaqi_CheckedChanged(object sender, EventArgs e)
        {


            if (cmbPollutant.Items.Contains(pm10))

            {
                cmbPollutant.Items.Remove(pm10);

            }

            if (cmbPollutant.Items.Contains("PM2.5"))
            {
                cmbPollutant.Items.Remove("PM2.5");
            }

            if (cmbPollutant.Items.Contains("SO2"))
            {
                cmbPollutant.Items.Remove("SO2");
            }

            if (cmbPollutant.Items.Contains("NO2"))
            {
                cmbPollutant.Items.Remove("NO2");
            }

            if (cmbPollutant.Items.Contains("O3"))
            {
                cmbPollutant.Items.Remove("O3");
            }

            if (cmbPollutant.Items.Contains("CO"))
            {
                cmbPollutant.Items.Remove("CO");
            }

            if (rdbtnPunjabaqi.Checked)
            {
                cmbPollutant.Items.Add(pm10);
                cmbPollutant.Items.Add("PM2.5");
                cmbPollutant.Items.Add("SO2");
                cmbPollutant.Items.Add("NO2");
                cmbPollutant.Items.Add("O3");
                cmbPollutant.Items.Add("CO");
            }

        }

        private void rdbtnUsaqi_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbPollutant.Items.Contains("PM10"))

            {
                cmbPollutant.Items.Remove("PM10");

            }

            if (cmbPollutant.Items.Contains("PM2.5"))
            {
                cmbPollutant.Items.Remove("PM2.5");
            }

            if (cmbPollutant.Items.Contains("SO2"))
            {
                cmbPollutant.Items.Remove("SO2");
            }

            if (cmbPollutant.Items.Contains("NO2"))
            {
                cmbPollutant.Items.Remove("NO2");
            }

            if (cmbPollutant.Items.Contains("O3 (8hours)"))
            {
                cmbPollutant.Items.Remove("O3 (8hours)");
            }

            if (cmbPollutant.Items.Contains("O3 (1hour)"))
            {
                cmbPollutant.Items.Remove("O3 (1hour)");
            }

            if (cmbPollutant.Items.Contains("CO"))
            {
                cmbPollutant.Items.Remove("CO");
            }

            if (rdbtnUsaqi.Checked)
            {
                cmbPollutant.Items.Add("PM10");
                cmbPollutant.Items.Add("PM2.5");
                cmbPollutant.Items.Add("SO2");
                cmbPollutant.Items.Add("NO2");
                cmbPollutant.Items.Add("O3 (8hours)");
                cmbPollutant.Items.Add("O3 (1hour)");
                cmbPollutant.Items.Add("CO");
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

        private void cmbPollutant_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbPollutant.Items.Contains(pm10))
            {
                lblUnit.Text = "ug/m3";
            }

            //this.cmbPollutant.SelectedItem.Contains("");
            //lblUnit.Text = ("ug/m3");
        }
    }
}

 
