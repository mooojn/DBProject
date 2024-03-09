using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    internal static class Program
    {
        public static string connectionString = "Data Source=DESKTOP-AJHCE58\\MOOOJN;Initial Catalog=ProjectB;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionString);
        public static int RegNo = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegNo = GetRegNo();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Uet());
        }
        static int GetRegNo()
        {
            connection.Open();
            string query = "SELECT RegistrationNumber From Student " +
                            "Where id = (SELECT MAX(id) FROM Student)";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int regNo = Convert.ToInt32(reader["RegistrationNumber"]);
            connection.Close();
            return ++regNo;
        }
    }
}
