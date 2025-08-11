using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace DharshanWEB.Models
{
    public class AdminModels
    {
        public List<Dictionary<string, string>> GetCustomer(){
        List<Dictionary<string,string>> list = new List<Dictionary<string,string>>();
            Dictionary<string,string> cust = null;
            DataBaseConnection.connection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("select*from portfolio", DataBaseConnection.con);
                cmd.CommandType = CommandType.Text;
                DataBaseConnection.con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cust = new Dictionary<string, string>();
                    cust.Add("name_rsm", dr["name_rsm"].ToString());
                    cust.Add("email_rsm", dr["email_rsm"].ToString());
                    cust.Add("subject_rsm", dr["subject_rsm"].ToString());
                    cust.Add("message_rsm", dr["message_rsm"].ToString());
                    list.Add(cust);
                }
                dr.Close();
                DataBaseConnection.con.Close();
                cmd.Dispose();
            }
            catch (Exception ex) { }
            return list;
        }
    }
}