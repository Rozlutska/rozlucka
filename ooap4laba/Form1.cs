using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ooap4laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cslculateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string position = positionTextBox.Text;
            decimal baseRate = decimal.Parse(rateTextBox.Text);
            int workQuantity = int.Parse(quantityTextBox.Text);

            Worker worker;

            if (hourlyRadioButton.Checked)
            {
                worker = new HourlyWorker(name, position, new HourlyPayment());
            }
            else
            {
                worker = new PieceworkWorker(name, position, new PieceworkPayment());
            }

            decimal salary = worker.CalculateSalary(baseRate, workQuantity);
            resultLabel.Text = $"Зарплата: {salary} грн";
        }
    }
}
