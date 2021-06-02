using System;

namespace BackEndAlbergue.Data.Repository
{
    public class Repository : IRepository
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=airline;";
        static string query = "SELECT * FROM Flights";
        private FlightEntity _firstFlight = null;
        private FlightEntity _lastFlight = null;

        public Repository()
        {
            _firstFlight = new FlightEntity();
            _lastFlight = new FlightEntity();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = $"SELECT * from Flights order by id asc limit 1;";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
        }

        public IEnumerable<FlightEntity> GetFlights()
        {
            List<FlightEntity> Flights = new List<FlightEntity>();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader _reader = commandDatabase.ExecuteReader();
            if (_reader.HasRows)
            {
                while (_reader.Read())
                {
                    FlightEntity Flight = new FlightEntity();
                    Flight.Id = _reader.GetInt32(0);
                    Flight.Name = _reader.GetString(1);
                    Flight.Sex = _reader.GetChar(2);
                    Flight.Description = _reader.GetString(3);
                }
                databaseConnection.Close();
            }
            return Flights;
        }
    }
}
