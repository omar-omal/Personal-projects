using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarBooking
{
    public partial class RentUI : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H8LFMTP;Initial Catalog=RentalCars;Integrated Security=True");
        dbContext dbContext = new dbContext();
        int carCategory;

        public RentUI()
        {

            InitializeComponent();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            
            string personNumber = personTextBox.Text;
            string distanceBefore = distanceTextbox.Text;
            dbContext.registerRent(carCategory, personNumber, distanceBefore);
            Close();
        }

        private void RentUI_Load(object sender, EventArgs e)
        {

            //Display data into combobox
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from dbo.Category;", con);
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            categoryComboBox.ValueMember = "Name";
            categoryComboBox.DataSource = dataTable;
            con.Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carCategory = categoryComboBox.SelectedIndex + 1;

        }
    }
}
