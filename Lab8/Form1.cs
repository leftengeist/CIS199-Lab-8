//N5284
//Lab 8
//March 31, 2019
//CIS 199-75
//GUI to calculate the net present value using methods and users input

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Lab8 : Form
    {
        public Lab8()
        {
            InitializeComponent();
        }

        // When you press the "Calculate" button the inputs are taken and given to the CalcPresentValue method, and recieves then outputs the present value from the method
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double futureValue;     //User input for the future value
            double rate;            //user input for the annual interest rate
            double presentValue;    //Calculated output for the present value

            int year;               //User input for the number of years
            
            // Check to see if inputs are valid
            if (Double.TryParse(inFutureValueTxt.Text, out futureValue) && futureValue >= 0)
            {
                if (Double.TryParse(inYearlyInterestTxt.Text, out rate) && rate >= 0)
                {
                    if (Int32.TryParse(inYearsTxt.Text, out year) && year >= 0)
                    {
                        // Call the calculation method and output results
                        presentValue = CalcPresentValue(futureValue, rate, year);
                        outPresentValueLbl.Text = $"{presentValue:C}";
                    }
                    else
                        MessageBox.Show("Input Valid Number of Years");
                }
                else
                    MessageBox.Show("Input Valid Annual Interest Rate");
            }
            else
                MessageBox.Show("Input Valid Future Value");
        }

        // When you press the "Clear" Button all text boxes and output labels are cleared
        private void clearBtn_Click(object sender, EventArgs e)
        {
            inFutureValueTxt.Text = $"";
            inYearlyInterestTxt.Text = $"";
            inYearsTxt.Text = $"";
            outPresentValueLbl.Text = $"";
        }

        // Method that takes the users input values for the future value, rate, and year then calculates the present value and returns it to the main method
        public static double CalcPresentValue(double futureValue, double rate, int year)
        {
            double presentValue; // The present value that is calculated
            
            // Calculation and output
            presentValue = futureValue / (Math.Pow(1 + rate, year));
            return presentValue;
        }
    }
}
