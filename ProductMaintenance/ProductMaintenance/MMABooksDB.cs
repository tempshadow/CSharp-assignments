using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    /// <summary>
    /// Establishes a connection to the MMABooks database locally
    /// Created by Nigel Mansell
    /// Date: 3/20/2017
    /// </summary>
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "AttachDbFileName=|DataDirectory|\\MMABooks.mdf;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        } 

    }
}
