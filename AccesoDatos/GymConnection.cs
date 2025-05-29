using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace GymApp.AccesoDatos
{
    public class GymConnection
    {
        private static GymConnection instance;
        public SqlConnection Connection { get; private set; }

        private GymConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GymDB"].ConnectionString;
            Connection = new SqlConnection(connectionString);
        }

        public static GymConnection GetInstance()
        {
            if (instance == null)
                instance = new GymConnection();
            return instance;
        }
    }
}
