using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Find_turkish_singers
{

    class Countries
    {
        static string connectionString = @"Data Source=OMAR-THINK\SQLEXPRESS;Initial Catalog=BirthMonthsDB;Integrated Security=True";
        static void UpdateCountryData(string country, string ISOCode)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            new SqlCommand("Update countries set ISOCode='"+ ISOCode +"' where title='"+ country +"'", conn).ExecuteNonQuery();
            conn.Close();
        }
    }
}
