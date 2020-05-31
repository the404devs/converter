using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjStuff
{
    public partial class Form1 : Form
    {
        /*Instance Variables*/
        double length = 0;

        /*Functions*/
        void InchCm()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 2.54;
            lblOutput.Text = (length + " Centimetres");
        }

        void FeetCm()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 30.48;
            lblOutput.Text = (length + " Centimetres");
        }

        void YardM()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 0.9144;
            lblOutput.Text = (length + " Metres");
        }

        void MileKm()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 1.60934;
            lblOutput.Text = (length + " Kilometres");
        }

        void CmInch()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 0.393701;
            lblOutput.Text = (length + " Inches");
        }

        void CmFeet()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 0.0328084;
            lblOutput.Text = (length + " Feet");
        }

        void MYard()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 1.09361;
            lblOutput.Text = (length + " Yards");
        }

        void KmMile()
        {
            length = Convert.ToInt16(txtInput.Text);
            length = length * 0.621371;
            lblOutput.Text = (length + " Miles");
        }  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItoC_Click(object sender, EventArgs e)
        {
            InchCm();
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            FeetCm();
        }

        private void btnYtoM_Click(object sender, EventArgs e)
        {
            YardM();
        }

        private void btnMitoK_Click(object sender, EventArgs e)
        {
            MileKm();
        }

        private void btnCtoI_Click(object sender, EventArgs e)
        {
            CmInch();
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            CmFeet();
        }

        private void btnMtoY_Click(object sender, EventArgs e)
        {
            MYard();
        }

        private void btnKtoMi_Click(object sender, EventArgs e)
        {
            KmMile();
        }
    }
}
