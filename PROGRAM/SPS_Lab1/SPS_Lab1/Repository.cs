using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Lab1
{
    public class Repository
    {
        MySqlConnection connection { get; set;}
        
        public Repository()
        {

        }
        public Repository(string connectionStr)
        {
            this.connection = new MySqlConnection(connectionStr);
        }
        public async void connect()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
                await connection.OpenAsync();
        }

        public async void closeConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
                await connection.CloseAsync();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        //Получения данных из таблицы
        public MySqlDataAdapter getFullTable(int tableindex,string tableName)
        {
            connect();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sql = String.Format("SELECT * FROM {0}", tableName);
            adapter.SelectCommand = new MySqlCommand(sql, connection);
            return adapter;
        }
        //Вставка данных в таблицу "Country"
        public MySqlDataAdapter InsertCountry (MySqlCommandBuilder commandBuilder)
        {
            string sql = String.Format("SELECT * FROM Country");
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql,connection);
            commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.InsertCommand = new MySqlCommand("sp_insertCountry", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("countryName", MySqlDbType.VarChar, 30, "Name"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("population", MySqlDbType.Int32,0, "Population"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("countryLanguage", MySqlDbType.VarChar,20, "Language"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("latitude", MySqlDbType.Decimal, 0, "Latitude"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("longitude", MySqlDbType.Decimal, 0, "Longitude"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("flag", MySqlDbType.Blob, 0, "Flag"));

            MySqlParameter idParam = adapter.InsertCommand.Parameters.Add("id", MySqlDbType.Int32, 0, "Id");
            idParam.Direction = ParameterDirection.Output;

            return adapter;
        }
        //Вставка данных в таблицу "Venues"
        public MySqlDataAdapter InsertVenue(MySqlCommandBuilder commandBuilder)
        {
            string sql = String.Format("SELECT * FROM Venus");
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.InsertCommand = new MySqlCommand("sp_insertVenue", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("vanueName", MySqlDbType.VarChar, 30, "Name"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("isFree", MySqlDbType.Int32,0, "IsFree"));
            adapter.InsertCommand.Parameters.Add(new MySqlParameter("photo", MySqlDbType.Blob, 0, "Photo"));

            MySqlParameter idParam = adapter.InsertCommand.Parameters.Add("id", MySqlDbType.Int32, 0, "Id");
            idParam.Direction = ParameterDirection.Output;

            return adapter;
        }
        //Вставка данных в таблицу "Events"
        public MySqlDataAdapter InsertEvent(MySqlCommandBuilder commandBuilder)
        {
            MySqlDataAdapter adapter = null;
            try
            {
                string sql = String.Format("SELECT * FROM Events");
                adapter = new MySqlDataAdapter(sql, connection);
                commandBuilder = new MySqlCommandBuilder(adapter);
                adapter.InsertCommand = new MySqlCommand("sp_insertEvent", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                MySqlParameter nameParam = new MySqlParameter("eventName", MySqlDbType.VarChar, 30, "Name");
                adapter.InsertCommand.Parameters.Add(nameParam);
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("startDate", MySqlDbType.Timestamp, 0, "StartDate"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("sponsor", MySqlDbType.VarChar, 40, "Sponsor"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("isFree", MySqlDbType.Int32, 0, "IsFree"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("cost", MySqlDbType.Int32, 0, "Cost"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("logo", MySqlDbType.Blob, 0, "Logo"));
                MySqlParameter vanueNameParam = new MySqlParameter("vanueName", MySqlDbType.VarChar, 30, "VenueName");
                adapter.InsertCommand.Parameters.Add(vanueNameParam);
                MySqlParameter idParam = adapter.InsertCommand.Parameters.Add("@outerId", MySqlDbType.Int32, 0, "Id");
                MySqlParameter idVenueParam = adapter.InsertCommand.Parameters.Add("@outerVenueId", MySqlDbType.Int32, 0, "VenueId");
                idParam.Direction = ParameterDirection.Output;
                idVenueParam.Direction = ParameterDirection.Output;
            }
            catch(MySqlException ex) {
                throw ex;
            }
            return adapter;
        }
    }
}
