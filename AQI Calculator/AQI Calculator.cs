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

       

        public int Linear(int AQIhigh, int AQIlow, double Conchigh, double Conclow, float Concentration)
        {
            int linear;
            double tempCal;
            tempCal = ((Concentration - Conclow) / (Conchigh - Conclow)) * (AQIhigh - AQIlow) + AQIlow;
            linear = (int)Math.Round(tempCal);
            return linear;
        }


        public int AQIPM25(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)(Math.Floor(10 * Concentration) / 10);
            if (c >= 0 && c < 12.1)
            {
                AQI = Linear(50, 0, 12, 0, c);
            }
            else if (c >= 12.1 && c < 35.5)
            {
                AQI = Linear(100, 51, 35.4, 12.1, c);
            }
            else if (c >= 35.5 && c < 55.5)
            {
                AQI = Linear(150, 101, 55.4, 35.5, c);
            }
            else if (c >= 55.5 && c < 150.5)
            {
                AQI = Linear(200, 151, 150.4, 55.5, c);
            }
            else if (c >= 150.5 && c < 250.5)
            {
                AQI = Linear(300, 201, 250.4, 150.5, c);
            }
            else if (c >= 250.5 && c < 350.5)
            {
                AQI = Linear(400, 301, 350.4, 250.5, c);
            }
            else if (c >= 350.5 && c < 500.5)
            {
                AQI = Linear(500, 401, 500.4, 350.5, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }

        public int AQIPM10(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(Concentration);
            if (c >= 0 && c < 55)
            {
                AQI = Linear(50, 0, 54, 0, c);
            }
            else if (c >= 55 && c < 155)
            {
                AQI = Linear(100, 51, 154, 55, c);
            }
            else if (c >= 155 && c < 255)
            {
                AQI = Linear(150, 101, 254, 155, c);
            }
            else if (c >= 255 && c < 355)
            {
                AQI = Linear(200, 151, 354, 255, c);
            }
            else if (c >= 355 && c < 425)
            {
                AQI = Linear(300, 201, 424, 355, c);
            }
            else if (c >= 425 && c < 505)
            {
                AQI = Linear(400, 301, 504, 425, c);
            }
            else if (c >= 505 && c < 605)
            {
                AQI = Linear(500, 401, 604, 505, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }


        public int AQICO(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(10 * Concentration) / 10;
            if (c >= 0 && c < 4.5)
            {
                AQI = Linear(50, 0, 4.4, 0, c);
            }
            else if (c >= 4.5 && c < 9.5)
            {
                AQI = Linear(100, 51, 9.4, 4.5, c);
            }
            else if (c >= 9.5 && c < 12.5)
            {
                AQI = Linear(150, 101, 12.4, 9.5, c);
            }
            else if (c >= 12.5 && c < 15.5)
            {
                AQI = Linear(200, 151, 15.4, 12.5, c);
            }
            else if (c >= 15.5 && c < 30.5)
            {
                AQI = Linear(300, 201, 30.4, 15.5, c);
            }
            else if (c >= 30.5 && c < 40.5)
            {
                AQI = Linear(400, 301, 40.4, 30.5, c);
            }
            else if (c >= 40.5 && c < 50.5)
            {
                AQI = Linear(500, 401, 50.4, 40.5, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }


        public int AQISO2(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(Concentration);
            if (c >= 0 && c < 36)
            {
                AQI = Linear(50, 0, 35, 0, c);
            }
            else if (c >= 36 && c < 76)
            {
                AQI = Linear(100, 51, 75, 36, c);
            }
            else if (c >= 76 && c < 186)
            {
                AQI = Linear(150, 101, 185, 76, c);
            }
            else if (c >= 186 && c <= 304)
            {
                AQI = Linear(200, 151, 304, 186, c);
            }
            else if (c >= 304 && c <= 604)
            {
                AQI = Linear(300, 201, 604, 305, c);
            }
            else if (c >= 605 && c < 805)
            {
                AQI = Linear(400, 301, 804, 605, c);
            }
            else if (c >= 805 && c <= 1004)
            {
                AQI = Linear(500, 401, 1004, 805, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }


        public int AQIO38hr(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(Concentration) / 1000;
            if (c >= 0 && c < .055)
            {
                AQI = Linear(50, 0, 0.054, 0, c);
            }
            else if (c >= .055 && c < .071)
            {
                AQI = Linear(100, 51, .070, .055, c);
            }
            else if (c >= .071 && c < .086)
            {
                AQI = Linear(150, 101, .085, .071, c);
            }
            else if (c >= .086 && c < .106)
            {
                AQI = Linear(200, 151, .105, .086, c);
            }
            else if (c >= .106 && c < .201)
            {
                AQI = Linear(300, 201, .200, .106, c);
            }
            else if (c >= .201 && c < .605)
            {
                MessageBox.Show("This value is available in O3 1hour concentration.");
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }


        public int AQIO31hr(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(Concentration) / 1000;
            if (c >= 0 && c <= .124)
            {
                MessageBox.Show("This value is available in O3 8hour concentration.");
            }

            else if (c >= .125 && c < .165)
            {
                AQI = Linear(150, 101, .164, .125, c);
            }
            else if (c >= .165 && c < .205)
            {
                AQI = Linear(200, 151, .204, .165, c);
            }
            else if (c >= .205 && c < .405)
            {
                AQI = Linear(300, 201, .404, .205, c);
            }
            else if (c >= .405 && c < .505)
            {
                AQI = Linear(400, 301, .504, .405, c);
            }
            else if (c >= .505 && c < .605)
            {

                AQI = Linear(500, 401, .604, .505, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }


        public int AQINO2(float Concentration)
        {
            float c;
            int AQI = 0;
            c = (float)Math.Floor(Concentration) / 1000;
            if (c >= 0 && c < .054)
            {
                AQI = Linear(50, 0, .053, 0, c);
            }
            else if (c >= .054 && c < .101)
            {
                AQI = Linear(100, 51, .100, .054, c);
            }
            else if (c >= .101 && c < .361)
            {
                AQI = Linear(150, 101, .360, .101, c);
            }
            else if (c >= .361 && c < .650)
            {
                AQI = Linear(200, 151, .649, .361, c);
            }
            else if (c >= .650 && c < 1.250)
            {
                AQI = Linear(300, 201, 1.249, .650, c);
            }
            else if (c >= 1.250 && c < 1.650)
            {
                AQI = Linear(400, 301, 1.649, 1.250, c);
            }
            else if (c >= 1.650 && c <= 2.049)
            {
                AQI = Linear(500, 401, 2.049, 1.650, c);
            }
            else
            {
                MessageBox.Show("Note: Values above 500 are considered Beyond the AQI.");
            }
            return AQI;
        }

        public frmMain()
        {
            InitializeComponent();
            public static int PM10()
            {

            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnPunjabaqi_CheckedChanged(object sender, EventArgs e)
        {
            // When Punjab AQI Radio button clicked, it will add the following pollutants in Combo box.

            lblUnit.Text = "Unit";
            cmbPollutant.Items.Clear();
            
            if (rdbtnPunjabaqi.Checked)
            {
                cmbPollutant.Items.Add("PM10");
                cmbPollutant.Items.Add("PM2.5");
                cmbPollutant.Items.Add("SO2");
                cmbPollutant.Items.Add("NO2");
                cmbPollutant.Items.Add("O3");
                cmbPollutant.Items.Add("CO");
            }

        }

        private void rdbtnUsaqi_CheckedChanged(object sender, EventArgs e)
        {
            // When Punjab AQI Radio button clicked, it will add the following pollutants in Combo box.

            lblUnit.Text = "Unit";
            cmbPollutant.Items.Clear();

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

        private void cmbPollutant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When a specific pollutant is selected Unit label will change into correspoding unit.


            string finalItem = cmbPollutant.SelectedItem.ToString();

            switch (finalItem)
            {
                case "PM10":
                    lblUnit.Text = "ug/m3";
                    break;

                case "PM2.5":
                    lblUnit.Text = "ug/m3";
                    break;

                case "SO2":
                    lblUnit.Text = "ppb";
                    break;

                case "NO2":
                    lblUnit.Text = "ppb";
                    break;

                case "O3":
                    lblUnit.Text = "ppb";
                    break;

                case "O3 (8hours)":
                    lblUnit.Text = "ppb";
                    break;

                case "O3 (1hour)":
                    lblUnit.Text = "ppb";
                    break;

                case "CO":
                    lblUnit.Text = "ppm";
                    break;

                default:
                    lblUnit.Text = "Unit";
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
          



            if (rdbtnUsaqi.Checked)
            {
                string finalItem = cmbPollutant.SelectedItem.ToString();

                switch (finalItem)
                {
                    case "PM10":
                        // geting the textbox value
                        string cal = txtBoxValue.Text;
                        float a;

                        // check if the value is a number or not a number
                        if (!float.TryParse(cal, out a))
                        {
                            MessageBox.Show("Only numbers are accepted");
                            return;
                        }

                        // parsing the textbox value to a float/number for calculation purpose
                        float parsedCal;
                        parsedCal = float.Parse(cal);

                        int tempAQI;
                        tempAQI = AQIPM10(parsedCal);

                        lblAqi.Text = tempAQI.ToString();
                        break;

                    case "PM2.5":
                        
                        break;
                }
            }



          /*  // geting the textbox value
            string cal = txtBoxValue.Text;
            float a;

            // check if the value is a number or not a number
            if (!float.TryParse(cal, out a))
            {
                MessageBox.Show("Only numbers are accepted");
                return;
            }

            // parsing the textbox value to a float/number for calculation purpose
            float parsedCal;
            parsedCal = float.Parse(cal);

            int tempAQI;
            tempAQI = AQIPM10(parsedCal);

            lblAqi.Text = tempAQI.ToString();



            */


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all the fields to default values
            lblUnit.Text = "Unit";
            cmbPollutant.Items.Clear();
            txtBoxValue.Text = "";
            rdbtnPunjabaqi.Checked = false;
            rdbtnUsaqi.Checked = false;
            lblAqi.Text = "0";
            lblAqicategory.Text = "NIL";
        }
    }
}

 
