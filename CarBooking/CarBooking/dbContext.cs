using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CarBooking
{
    public class dbContext
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H8LFMTP;Initial Catalog=RentalCars;Integrated Security=True");

        public void registerRent(int carCategory, string personNumber, int distanceBefore)
        {
            
            string query = "INSERT INTO dbo.CarRent (CategoryId, PersonNumber, Date_before,DistanceCounter_before) VALUES (@carCategory, @personNumber, @currentDate,@distanceReading);";
            DateTime currentDate = DateTime.Now;

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@carCategory", carCategory);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);
            cmd.Parameters.AddWithValue("@distanceReading", distanceBefore);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void returnCar(string personNumber, int distanceAfter)
        {
            string query = "UPDATE dbo.CarRent SET DistanceCounter_after=@distanceAfter, Date_after=@currentDate WHERE PersonNumber=@personNumber;";
            DateTime currentDate = DateTime.Now;

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@distanceAfter", distanceAfter);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);

            cmd.ExecuteNonQuery();
            con.Close();
        }


        //public decimal calculateRentCost()
        //{

        //    //Calculate rent price
        //}



    }
}
