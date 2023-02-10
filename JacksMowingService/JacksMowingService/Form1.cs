/*
 * Author: Samuel Greenlee
 * Project: Assignment Three
 * Date  : Febuary 7 2020
 * Desc  : Calculates the hours and pay amount recived durring a five day period
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacksMowingService
{
    public partial class frmJacksMowingService : Form
    {
        public frmJacksMowingService()
        {
            InitializeComponent();
        }

        //Broad scope variable declaration
        int fiveDayWeekNum = 0;

        //string array containing the number of days
        string[] dayNum = { "Day 1", "Day 2", "Day 3", "Day 4", "Day 5" }; //Space out if need to when done programming

        //int array for hours
        int[] dayHours = new int[5];

        //decimal array for pay
        decimal[] dayPay = new decimal[5];

        private void frmJacksMowingService_Load(object sender, EventArgs e)
        {
            // prompt
            DisplayPrompt();
        }

        private void btnCalculateRate_Click(object sender, EventArgs e)
        {
            //Variable declaration
            int hours;
            decimal pay;
            decimal hourlyRate;
            decimal average;

            //Data validation           
            if(DataValid() && fiveDayWeekNum < 5)
            {
                //Get the hours for the day
                hours = Convert.ToInt32(txtDayHours.Text);

                //Put the hours for the day in the hours int array
                dayHours[fiveDayWeekNum] = hours;

                //Get the pay for the day
                pay = Convert.ToDecimal(txtDayPay.Text);

                //Put the pay for the day in the pay decimal array
                dayPay[fiveDayWeekNum] = pay;

                //Display the days entered
                DisplayDaysEntered();

                //Calculate the hourly rate for the current day
                hourlyRate = CalculateHourlyRate();

                //Display the current day hourly rate
                DisplayHourlyRate(hourlyRate);

                //Calculate the average rate for the days entered
                average = CalculateAverageRate();

                //Display the average for the days entered
                DisplayAverage(average);

                //Get ready for the next day
                fiveDayWeekNum++;

                //Display the next prompt for the next day
                DisplayPrompt();
            }
        }

        //This method displays the prompt at the left of the program
        private void DisplayPrompt()
        {
            if (fiveDayWeekNum < 5)
            {
                lblDayDisplay.Text = dayNum[fiveDayWeekNum];
            }
            else
            {
                lblDayDisplay.Text = "No more temps please";
                btnCalculateRate.Enabled = false;
            }
        }

        //This method displays the number of days entered
        private void DisplayDaysEntered()
        {
            int dayNum = fiveDayWeekNum + 1;

            txtDaysEntered.Text = dayNum.ToString();
        }

        //This method calculates the hourly rate for the current day
        private decimal CalculateHourlyRate()
        {
            decimal total;

            total = dayPay[fiveDayWeekNum] / dayHours[fiveDayWeekNum];

            return total;
        }

        //This method displays the hourly rate for the current day
        private void DisplayHourlyRate(decimal hourlyRate)
        {
            txtHourlyRate.Text = hourlyRate.ToString("f2");
        }

        //This method calculates the average hourly rate for the days entered
        private decimal CalculateAverageRate()
        {
            decimal hours = 0.0m;
            decimal pay = 0.0m;
            decimal average;

            for (int index = 0; index <= fiveDayWeekNum; index++)
            {
                hours += dayHours[index];
            }
            for (int index = 0; index <= fiveDayWeekNum; index++)
            {
                pay += dayPay[index];
            }

            average = pay / hours;

            return average;
        }

        //This method displays the average rate for the days entered
        private void DisplayAverage(decimal average)
        {
            txtAverageRate.Text = average.ToString("f2");
        }

        //These are the methods for data validation
        private bool DataValid()
        {
            return
                IsInt32(txtDayHours, "Hours")&&
                IsDecimal(txtDayPay, "Pay");
        }

        private bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a integer ", "Entry Error");
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

         private bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if(Decimal.TryParse(textBox.Text,out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value", "Entry Error");
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }
        }

        //Exit button
        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Reset button
        private void txtReset_Click(object sender, EventArgs e)
        {
            //Sets the day counter to zero
            fiveDayWeekNum = 0;

            //Resets the prompt
            DisplayPrompt();

            //Renables the calculate rate button
            btnCalculateRate.Enabled = true;

            //Clears the array
            ClearArray();

            //Clears the form
            txtDayHours.Clear();
            txtDayPay.Clear();
            txtDaysEntered.Clear();
            txtHourlyRate.Clear();
            txtAverageRate.Clear();
        }

        //This method clears the array and is called by the reset button
        private void ClearArray()
        {
            for(int index = 0; index <= dayHours.GetUpperBound(0); index++)
            {
                dayHours[index] = 0;
            }

            for(int index = 0; index <= dayPay.GetUpperBound(0); index++)
            {
                dayPay[index] = 0;
            }
        }

        //This method is for the show stats button
        //This method shows the stats in a message box of the days number, hours and pay for the days entered
        private void txtShowStats_Click(object sender, EventArgs e)
        {
            string display= "";
            string allPay = "";
            
            for(int i = 0; i <= dayHours.GetUpperBound(0); i++)             
            {
            if(dayHours[i] > 0)
                {
                    allPay = dayPay[i].ToString("c");
                    display += dayNum[i] + " " + dayHours[i].ToString() + " " + allPay + " \n";
                }
            }

            MessageBox.Show(display, "Entered Values");
        }
    }
}
