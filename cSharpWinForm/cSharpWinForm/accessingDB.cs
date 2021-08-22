using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace cSharpWinForm
{
    public class accessingDB
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Aylik Satis Raporu;integrated security=true");

        public DataTable GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Shopping",_connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }
        void data()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Aylik Satis Raporu;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("insert into urunler values(@a,@b,@c)",connection);
            command.Parameters.AddWithValue("@a", "bilgisayar");
            command.Parameters.AddWithValue("@b", "15");
            command.Parameters.AddWithValue("@c", "8000");
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("delete from urunler", connection);
            command2.ExecuteNonQuery();
        }

        //son ayda yapilmis olan alisveris bilgilerini isler.
        public void monthAnalyser(int year,int month,ref int totalSpend_M)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Shopping where getYear=@year and getMonth=@month", _connection);
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@month",month);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                totalSpend_M += reader.GetInt32(5);
            }
            reader.Close();
            
        }


        public void yearAnalyser(int year,ref int totalSpend_Y)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("select * from Shopping where getYear=@year",_connection);
            command.Parameters.AddWithValue("@year", year);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                totalSpend_Y += reader.GetInt32(5);
            }
            reader.Close();
        }

        public void addNewShopping(string productName,int getYear,int getMonth,int getDay, int productPrice)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("insert into Shopping values(@productName,@getYear,@getMonth,@getDay,@productPrice)",_connection);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@getYear", getYear);
            command.Parameters.AddWithValue("@getMonth", getMonth);
            command.Parameters.AddWithValue("@getDay", getDay);
            command.Parameters.AddWithValue("@productPrice", productPrice);

            command.ExecuteNonQuery();

        }

        public void updateData(int id, string productName,int getYear,int getMonth, int getDay, int productPrice)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("update Shopping set productName=@productName,getYear=@getYear," +
                "getMonth=@getMonth,getDay=@getDay,productPrice=@productPrice where id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@getYear", getYear);
            command.Parameters.AddWithValue("@getMonth", getMonth);
            command.Parameters.AddWithValue("@getDay", getDay);
            command.Parameters.AddWithValue("@productPrice", productPrice);

            command.ExecuteNonQuery();

        }

        public void deleteData(int id)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("delete from Shopping where id=@id", _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }


    }
}
