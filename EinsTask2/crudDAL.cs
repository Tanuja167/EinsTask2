using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace EinsTask2
{
    public class crudDAL
    {
       SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public crudDAL()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconnection"].ConnectionString);
        }

        
        public int Add(User user)
        {
            int res = 0;
            string qry = "insert into Users values(@name, @address, @state, @city, @age)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@address", user.Address);

            cmd.Parameters.AddWithValue("@state", user.State);
            cmd.Parameters.AddWithValue("@city", user.City);
            cmd.Parameters.AddWithValue("@age", user.Age);
            con.Open();
            res = cmd.ExecuteNonQuery();
            return res;
        }

        public int Update(User user)
        {
            int res = 0;
            string qry = "Update Users set Name = @name, Address = @address, State = @state, City = @city, Age = @age where Id = @id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@address", user.Address);

            cmd.Parameters.AddWithValue("@state", user.State);
            cmd.Parameters.AddWithValue("@city", user.City);
            cmd.Parameters.AddWithValue("@age", user.Age);
            
            con.Open();
            res = cmd.ExecuteNonQuery();
            return res;

           

        }
    }
}