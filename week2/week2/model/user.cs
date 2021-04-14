using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    class user
    {
        MY_DB mydb = new MY_DB();
        public Boolean checkLogIn(string account,string password)
        {
           
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE user_Acc = @Acc AND user_PW =@PW ", mydb.getConnection);
            cmd.Parameters.Add("@Acc", SqlDbType.VarChar).Value = account;
            cmd.Parameters.Add("@PW", SqlDbType.VarChar).Value = password;
            SqlDataReader data = cmd.ExecuteReader();

            if (data.Read() == true)
            {
                mydb.closeConnection();
                return true;
            }
                mydb.closeConnection();
                return false;
        }
        public bool insertUser(string account, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (user_Acc,user_PW)" +
                " VALUES (@acc,@pw)", mydb.getConnection);
            command.Parameters.Add("@acc", SqlDbType.VarChar).Value = account;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
 }

