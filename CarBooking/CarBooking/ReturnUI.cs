using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarBooking
{
    public partial class ReturnUI : Form
    {
        dbContext dbContext = new dbContext();
        public ReturnUI()
        {
            InitializeComponent();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            string personNumber = txtboxPersonNumber.Text;
            int distanceAfter = int.Parse(txtboxDistance.Text);

            //Insert and modify  distanceAfter + dateAfter
            dbContext.returnCar(personNumber, distanceAfter);

            //Return price
            //dbContext.calculateRentCost(personNumber);
            MessageBox.Show("Kostnaden är: " + dbContext.calculateRentCost(personNumber));

            Close();
        }
    }
}
