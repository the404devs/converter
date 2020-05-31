using System;
using System.Reflection;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        double inputLength = 0;
        double inputTemp = 0;
        Version version = Assembly.GetEntryAssembly().GetName().Version;
        String[] charset = {"0","1","2","3","4","5","6","7","8","9","."};
        bool hasDecimal = false;

        public Converter()
        {
            InitializeComponent();
        }

        void convertTemps()
        {
            //checks
            if (tbTemp.Text == "")
            {
                lblError2.Text = "Please enter a temperature.";
            }
            else if (cboxLengthUnits.SelectedItem.ToString() == null)
            {
                lblError2.Text = "Please select a unit.";
            }
            else
            {
                lblError2.Text = "";
                inputTemp = Convert.ToDouble(tbTemp.Text);
                if (cboxTempUnits.SelectedItem.ToString() == "Celsius")
                {
                    lblC.Text = inputTemp + "°C";
                    lblF.Text = (inputTemp * 9) / 5 + 32 + "°F";
                    lblK.Text = inputTemp + 273.15 + "K";
                }
                else if (cboxTempUnits.SelectedItem.ToString() == "Fahrenheit")
                {
                    lblC.Text = ((inputTemp - 32) * 5) / 9 + "°C";
                    lblF.Text = inputTemp + "°F";
                    lblK.Text = (((inputTemp - 32) * 5) / 9) + 273.15 + "K";
                }
                else if (cboxTempUnits.SelectedItem.ToString() == "Kelvin")
                {
                    lblC.Text = inputTemp - 273.15 + "°C";
                    lblF.Text = ((inputTemp - 273.15) * 9) / 5 + 32 + "°F";
                    lblK.Text = inputTemp + "K";
                }

                if (lblF.Text == "200°F")
                {
                    lblF.Text = "Don't stop me now!";

                }
                else if (lblF.Text == "451°F")
                {
                    lblF.Text = "It was a pleasure to burn.";
                }
            }
        }

        void convertLengths()
        {
            //checks
            if (tbLength.Text == "")
            {
                lblError1.Text = "Please enter a length.";
            }
            else if (cboxLengthUnits.SelectedItem.ToString() == null)
            {
                lblError1.Text = "Please select a unit.";
            }
            else
            {
                lblError1.Text = "";
                inputLength = Convert.ToDouble(tbLength.Text);
                if (cboxLengthUnits.SelectedItem.ToString() == "Millimetres")
                {
                    lblMM.Text = inputLength + " mm";
                    lblCM.Text = inputLength / 10 + " cm";
                    lblM.Text = inputLength / 10 / 100 + "m";
                    lblKM.Text = inputLength / 10 / 100 / 1000 + " km";
                    lblIN.Text = inputLength * 0.0393701 + " inches";
                    lblFE.Text = inputLength * 0.00328084 + " feet";
                    lblYA.Text = inputLength * 0.00109361 + " yards";
                    lblMI.Text = inputLength * 6.2137e-7 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Centimetres")
                {
                    lblMM.Text = inputLength * 10 + " mm";
                    lblCM.Text = inputLength + " cm";
                    lblM.Text = inputLength / 100 + "m";
                    lblKM.Text = inputLength / 100 / 1000 + " km";
                    lblIN.Text = inputLength * 0.393701 + " inches";
                    lblFE.Text = inputLength * 0.0328084 + " feet";
                    lblYA.Text = inputLength * 0.0109361 + " yards";
                    lblMI.Text = inputLength * 6.2137e-6 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Metres")
                {
                    lblMM.Text = inputLength * 1000 + " mm";
                    lblCM.Text = inputLength * 100 + " cm";
                    lblM.Text = inputLength + "m";
                    lblKM.Text = inputLength / 1000 + " km";
                    lblIN.Text = inputLength * 39.3701 + " inches";
                    lblFE.Text = inputLength * 3.28084 + " feet";
                    lblYA.Text = inputLength * 1.09361 + " yards";
                    lblMI.Text = inputLength * 6.2137e-4 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Kilometres")
                {
                    lblMM.Text = inputLength * 1000000 + " mm";
                    lblCM.Text = inputLength * 100000 + " cm";
                    lblM.Text = inputLength * 1000 + "m";
                    lblKM.Text = inputLength + " km";
                    lblIN.Text = inputLength * 39370.1 + " inches";
                    lblFE.Text = inputLength * 3280.84 + " feet";
                    lblYA.Text = inputLength * 1093.61 + " yards";
                    lblMI.Text = inputLength * 0.621371 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Inches")
                {
                    lblMM.Text = inputLength * 25.4 + " mm";
                    lblCM.Text = inputLength * 2.54 + " cm";
                    lblM.Text = inputLength * 0.0254 + "m";
                    lblKM.Text = inputLength * 2.54e-5 + " km";
                    lblIN.Text = inputLength + " inches";
                    lblFE.Text = inputLength * 0.0833333 + " feet";
                    lblYA.Text = inputLength * 0.0277778 + " yards";
                    lblMI.Text = inputLength * 1.5783e-5 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Feet")
                {
                    lblMM.Text = inputLength * 304.8 + " mm";
                    lblCM.Text = inputLength * 30.48 + " cm";
                    lblM.Text = inputLength * 0.3048 + "m";
                    lblKM.Text = inputLength * 0.0003048 + " km";
                    lblIN.Text = inputLength * 12 + " inches";
                    lblFE.Text = inputLength + " feet";
                    lblYA.Text = inputLength * 0.333333 + " yards";
                    lblMI.Text = inputLength * 0.00018939375 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Yards")
                {
                    lblMM.Text = inputLength * 914.4 + " mm";
                    lblCM.Text = inputLength * 91.44 + " cm";
                    lblM.Text = inputLength * 0.9144 + "m";
                    lblKM.Text = inputLength * 0.0009144 + " km";
                    lblIN.Text = inputLength * 36 + " inches";
                    lblFE.Text = inputLength * 3 + " feet";
                    lblYA.Text = inputLength + " yards";
                    lblMI.Text = inputLength * 0.000568182 + " miles";
                }
                else if (cboxLengthUnits.SelectedItem.ToString() == "Miles")
                {
                    lblMM.Text = inputLength * 1.60934e+6 + " mm";
                    lblCM.Text = inputLength * 160934 + " cm";
                    lblM.Text = inputLength * 1609.34 + "m";
                    lblKM.Text = inputLength * 1.60934 + " km";
                    lblIN.Text = inputLength * 63360 + " inches";
                    lblFE.Text = inputLength * 5280 + " feet";
                    lblYA.Text = inputLength * 1760 + " yards";
                    lblMI.Text = inputLength + " miles";
                }
            }
        }

        private void lblConvLength_Click(object sender, EventArgs e)
        {
            convertLengths();
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            cboxLengthUnits.SelectedItem = cboxLengthUnits.Items[1];
            cboxTempUnits.SelectedItem = cboxTempUnits.Items[0];
        }

        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() != "." || e.KeyChar.ToString() != ".")
            {
                //!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                //this code prevents all characters except for numbers to be inputed
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        
        private void lblConvTemp_Click(object sender, EventArgs e)
        {
            convertTemps();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string vx = version.ToString();
            MessageBox.Show("Converter Version " + vx + "\n11/02/17\nBy Owen Goodwin");
        }

        private void tbLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertLengths();
                hasDecimal = false;
            }
        }

        private void tbTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                convertTemps();
                hasDecimal = false;
            }
        }

        private void tbTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() != "." || e.KeyChar.ToString() != ".")
            {
                //!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                //this code prevents all characters except for numbers to be inputed
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ".")
            {
                hasDecimal = true;
            }
        }

        private void lblConvLength_MouseEnter(object sender, EventArgs e)
        {
            lblConvLength.BackColor = System.Drawing.Color.Teal;
        }

        private void lblConvLength_MouseLeave(object sender, EventArgs e)
        {
            lblConvLength.BackColor = System.Drawing.Color.Turquoise;
        }

        private void lblConvTemp_MouseEnter(object sender, EventArgs e)
        {
            lblConvTemp.BackColor = System.Drawing.Color.Teal;
        }

        private void lblConvTemp_MouseLeave(object sender, EventArgs e)
        {
            lblConvTemp.BackColor = System.Drawing.Color.Turquoise;
        }
    }
}
