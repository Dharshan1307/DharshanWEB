using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DharshanWEB.Models
{
    public class PortoDatas
    {
        private static MySqlCommand cm;
        private static MySqlDataReader dr;
        private static MySqlDataAdapter da;

        public string AddCusValuesPost(PortDataValues portDataValues)
        {
            string status = "fales";
            DataBaseConnection.connection();
            DataBaseConnection.con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("portfolio_datavalues", DataBaseConnection.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name_rsm", portDataValues.name_rsm);
                cmd.Parameters.AddWithValue("@email_rsm", portDataValues.email_rsm);
                cmd.Parameters.AddWithValue("@subject_rsm",portDataValues.subject_rsm);
                cmd.Parameters.AddWithValue("@message_rsm", portDataValues.message_rsm);
                int count = cmd.ExecuteNonQuery();
                DataBaseConnection.con.Close();
                if (count > 0)
                {
                    status = "true";
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;
            }
            return status;
        }

    }
}