using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caclulator_App
{
    public partial class Form1 : Form
    {
        private string currentCaclulation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // add number or operator to calculator
            currentCaclulation += (sender as Button).Text;

            // displays those changes
            textBoxOutput.Text = currentCaclulation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCaclulation.ToString().Replace("x", "*").ToString().Replace("/", "/");

            try
            {
                textBoxOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCaclulation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCaclulation = "";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // reset the calculator
            textBoxOutput.Text = "0";
            currentCaclulation = "";
        }

        private void button_ClearEntry_click(object sender, EventArgs e)
        {
            // if calculation is not empty, removes the last number/ operator entered 
            if (currentCaclulation.Length > 0)
            {
                currentCaclulation = currentCaclulation.Remove(currentCaclulation.Length -1, 1);
            }
            
            // re-displays the calculation onto the screen
            textBoxOutput.Text = currentCaclulation;
        }

        private void buttonLeftBracket_Click(object sender, EventArgs e)
        {

        }
    }
}
