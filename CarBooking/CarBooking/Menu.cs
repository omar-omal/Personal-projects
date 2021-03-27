using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarBooking
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rentCarbtn_Click(object sender, EventArgs e)
        {
            
            RentUI rentUI = new RentUI();
            rentUI.ShowDialog();
        }

        private void returnCarbtn_Click(object sender, EventArgs e)
        {

            ReturnUI returnUI = new ReturnUI();
            returnUI.ShowDialog();

        }
    }
}
