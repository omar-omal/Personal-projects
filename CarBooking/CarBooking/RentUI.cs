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
        int carCategory;
         
        public RentUI()
        {
            
            InitializeComponent();
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-H8LFMTP;Initial Catalog=RentalCars;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO dbo.CarRent (CategoryId, PersonNumber, Date,Distance) VALUES ('1', '9009037517', '2019-03-09 00:00','5000');", con);
            //cmd.ExecuteNonQuery();
            //con.Close();

            string query = "INSERT INTO dbo.CarRent (CategoryId, PersonNumber, Date_before,DistanceCounter_before) VALUES (@carCategory, @personNumber, @currentDate,@distanceReading);";
            string personNumber = personTextBox.Text;
            string distanceReading = distanceTextbox.Text;
            
            DateTime currentDate = DateTime.Now;


            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@carCategory", carCategory);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);
            cmd.Parameters.AddWithValue("@distanceReading", distanceReading);
            cmd.ExecuteNonQuery();
            con.Close();

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
