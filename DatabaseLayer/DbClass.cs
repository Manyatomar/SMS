using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFormsApp1
{
    class DbClass : IDbClass
    {
        public class ConnectionString
        {
            private static string cName = "Data Source=DESKTOP-E3HO5KC\\SQLEXPRESS; Initial Catalog=SMSD; Integrated Security=True; TrustServerCertificate=True;Encrypt=false";
            public static string CName
            {
                get => cName;
            }
        }
        public bool ValidateCredential(string username, string password)
        {
            string Query = "select * from UserInfo where username=@UserName and password =@Password";
            string connectionString = ConnectionString.CName;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = con;
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            bool result = false;
            if (ds.Tables[0].Rows.Count != 0)
            {
                result = true;
            }
            return result;
        }
    }
}

