using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DharshanWEB.Models
{
    public class DataBaseConnection
    {
        public static MySqlConnection con;
        public static void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["datamodel"].ToString();
            con = new MySqlConnection(constring);
        }
    }
}