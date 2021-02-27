using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeShipmentTracker
{
    public partial class ShipmentsByEmployee : Form
    {
        // Declare constant variables.
        const int MaxDays = 7;
        const int NumberOfEmployees = 3;

        // Declare class level variables.
        int day = 1;
        int employee = 1;

        // Declare the array.
        int[,] employeeShippmentsArray = new int [NumberOfEmployees + 1, MaxDays];

        // Make arrays for output controls.
        TextBox[] employeeTextBoxes;
        TextBox[] employeeAveragers;

        public ShipmentsByEmployee()
        {
            InitializeComponent();

            labelDay.Text = "Day: " + day;

            employeeTextBoxes = new TextBox[] { textBoxEmployee1, textBoxEmployee2, textBoxEmployee3 };
            employeeAveragers = new TextBox[] { textBoxAverageOfEmployee1, textBoxAverageOfEmployee2, textBoxAverageOfEmployee3 };
        }

        /// <summary>
        /// When the enter button is clicked add the entry in the textbox to the total amount that the employee shipped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare variables and constants.
            const int MinUnits = 0;
            const int MaxUnits = 5000;

            // Validate the number entered is whole.
            if (int.TryParse(textBoxQuantityShippedEntry.Text, out employeeShippmentsArray[employee - 1, day - 1]))
            {
                // Validate the number entered is between 0 and 5000.
                if (employeeShippmentsArray[employee - 1, day - 1] >= MinUnits && 
                    employeeShippmentsArray[employee - 1, day - 1] <= MaxUnits)
                {
                    // Add what has been entered to the textbox of the current employee
                    employeeTextBoxes[employee - 1].Text += employeeShippmentsArray[employee - 1, day - 1] + "\r\n";

                    // Check if day is greater then or equal to the max day.
                    if (day++ >= MaxDays)
                    {
                        // Declare class level variables
                        // I must say I chose these names before you wrote them out so I swear I'm not copying!
                        int employeeTotal = 0;
                        int overallTotal = 0;
                        // Calculate the average for employee 1.
                        for (int dayCounter = 0; dayCounter < NumberOfEmployees; dayCounter++)
                        {
                            employeeTotal += employeeShippmentsArray[employee - 1, dayCounter];
                        }

                        employeeAveragers[employee -1].Text = "Average: " + Math.Round((double)employeeTotal / MaxDays, 2);

                        // Reset the day.
                        day = 1;
                        // Go to the next employee.
                        employee++;
                        

                    }

                    // Check if we have reached the maximum number of employees.
                    if (employee > NumberOfEmployees)
                    {
                        // Disable all appropriate controls and set focus to reset button.

                        // Disable the controls.
                        textBoxQuantityShippedEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                        // Set focus to the reset button.
                        buttonReset.Focus();
                    }

                    labelDay.Text = "Day: " + day;
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinUnits + " and " + MaxUnits + ".", "Woah!");
                    textBoxQuantityShippedEntry.SelectAll();
                    textBoxQuantityShippedEntry.Focus();
                }
            }
            else
            {
                // The value entered is not a whole number.
                MessageBox.Show("Enter a whole number", "Woah!");
                textBoxQuantityShippedEntry.SelectAll();
                textBoxQuantityShippedEntry.Focus();
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Function to reset form.
        /// </summary>
        private void ResetTracker()
        {
            // Clear all input and output fields.
            textBoxQuantityShippedEntry.Clear();
            textBoxEmployee1.Clear();
            textBoxEmployee2.Clear();
            textBoxEmployee3.Clear();
            textBoxPerDayAverage.Clear();
            textBoxAverageOfEmployee1.Clear();
            textBoxAverageOfEmployee2.Clear();
            textBoxAverageOfEmployee3.Clear();

            // Reset the class-level variables.
            day = 1;
            employee = 1;
            labelDay.Text = "Day " + day;

            // Enable all controls that were disabled when user finished.
            textBoxQuantityShippedEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Set the focus to the entry field.
            textBoxQuantityShippedEntry.Focus();
        }

        /// <summary>
        /// Resets the form to its default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            ResetTracker();
        }
    }
}
