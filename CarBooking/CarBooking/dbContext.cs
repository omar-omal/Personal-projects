﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CarBooking
{
    public class DbContext
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-H8LFMTP;Initial Catalog=RentalCars;Integrated Security=True");

        public void registerRent(int carCategory, string personNumber, int distanceBefore)
        {

            string query = "INSERT INTO dbo.CarRent (CategoryId, PersonNumber, Date_before,DistanceCounter_before) " +
                            "VALUES (@carCategory, @personNumber, @currentDate,@distanceReading);";
            DateTime currentDate = DateTime.Now;

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@carCategory", carCategory);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);
            cmd.Parameters.AddWithValue("@distanceReading", distanceBefore);
            cmd.ExecuteNonQuery();
            con.Close();

            //Sets isRented to true
            modifyRentStatus(personNumber, 1);
        }

        public void returnCar(string personNumber, int distanceAfter)
        {
            string query = "UPDATE dbo.CarRent SET DistanceCounter_after=@distanceAfter, Date_after=@currentDate " +
                            "WHERE PersonNumber=@personNumber;";
            DateTime currentDate = DateTime.Now;

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@distanceAfter", distanceAfter);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@currentDate", currentDate);
            cmd.ExecuteNonQuery();
            con.Close();

            //Sets isRented to false
            modifyRentStatus(personNumber, 0);
        }

        //Calculates cost based on registered records
        public decimal calculateRentCost(string personNumber)
        {
            string carCategory = "";
            int distanceBefore = 0, distanceAfter = 0, distanceTravled = 0, days = 0;
            decimal price = 0, pricePerDay = 640, pricePerKM = 20, dailyPrice = 0, pricePerDistance = 0;
            DateTime dateBefore = DateTime.MinValue, dateAfter = DateTime.MinValue;
            SqlDataReader dataReader;



            string query = "SELECT  DistanceCounter_before,  DistanceCounter_after, Date_before, Date_after, Name " +
                            "FROM dbo.CarRent INNER JOIN dbo.Category ON dbo.CarRent.CategoryId = dbo.Category.CategoryId " +
                            "WHERE PersonNumber =@personNumber; ";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                distanceBefore = (int)dataReader["DistanceCounter_before"];
                distanceAfter = (int)dataReader["DistanceCounter_after"];
                dateBefore = (DateTime)dataReader["Date_before"];
                dateAfter = (DateTime)dataReader["Date_after"];
                carCategory = dataReader["Name"].ToString();
            }
            con.Close();

            
            distanceTravled = distanceAfter - distanceBefore;
            days = dateAfter.Day - dateBefore.Day;
            dailyPrice = pricePerDay * days;
            pricePerDistance = pricePerKM * distanceTravled;


            //Calculate rent price based on category
            if (carCategory == "Smålbil")
            {
                return price = dailyPrice;
            }
            else if (carCategory == "Van")
            {
                return price = (dailyPrice * (decimal)1.2) + pricePerDistance;
            }
            else if (carCategory == "Minibuss")
            {
                return price = (dailyPrice * (decimal)1.7) + (pricePerDistance * (decimal)1.5);
            }
            else
            {
                return price = 0;
            }
        }

        //Returns bool value true if user has active rents
        public bool isRented(string personNumber)
        {
            int count=0;
            string query = "SELECT COUNT(*) FROM dbo.CarRent WHERE PersonNumber = @personNumber AND IsRented = 1;";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count >=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Modify the status of the isRented boolean 
        private void modifyRentStatus(string personNumber, int isRented)
        {
            string query = "UPDATE dbo.CarRent SET IsRented=@isRented WHERE PersonNumber=@personNumber;";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@personNumber", personNumber);
            cmd.Parameters.AddWithValue("@isRented", isRented);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
