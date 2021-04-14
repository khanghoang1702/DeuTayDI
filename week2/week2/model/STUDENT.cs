using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public DataTable getListStd()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable getListMale()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien where gender='Male'", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable getListFemale()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien where gender='Female'", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable getListMaleYes(DateTime start,DateTime end)
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien where gender='Male' and bdate>=@start and bdate<=@end", mydb.getConnection);
            cmd.Parameters.Add("@start", SqlDbType.VarChar).Value =start;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable getListFemaleYes(DateTime start, DateTime end)
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien where gender='Female' and  bdate>=@start and bdate<=@end", mydb.getConnection);
            cmd.Parameters.Add("@start", SqlDbType.VarChar).Value = start;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = end;
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable searchSTN(int ID)
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien WHERE id=@ID ", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;

        }
        public DataTable searchLabel(string label)
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien WHERE fname=@fname or lname=@lname or adresss=@address ", mydb.getConnection);
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = label;
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;

        }
        public bool insertStudent(int ID,string fname,string lname,DateTime bdate,string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SinhVien (id,fname,lname,bdate,gender,phone,adresss,picture)" + 
                " VALUES (@id,@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public bool updateStudent(int ID, string fname, string lname, DateTime bdate,string gender ,string phone, string address)
        {
            SqlCommand command = new SqlCommand("UPDATE SinhVien set fname=@fn,lname=@ln,bdate=@bd,gender=@gd,phone=@pn,adresss=@adr WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = address;
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
        public double studentStatics()
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand("Select count(*) from SinhVien", mydb.getConnection);
            int totalStd= Convert.ToInt32(command.ExecuteScalar());
            return totalStd;
        }
        public double studentCountLb(string label)
        {
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("Select count(*) from SinhVien WHERE fname=@fname or lname=@lname or adresss=@address ", mydb.getConnection);
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = label;
            int totalStd = Convert.ToInt32(cmd.ExecuteScalar());
            return totalStd;
        }
        public double femaleCount()
        {
            mydb.openConnection();
            string fmale = "Female";
            SqlCommand command = new SqlCommand("Select count(*) from SinhVien where gender=@fmale ", mydb.getConnection);
            command.Parameters.Add("@fmale", SqlDbType.VarChar).Value = fmale;
            int totalStd = Convert.ToInt32(command.ExecuteScalar());
            return totalStd;
        }
        public double maleCount()
        {
            string male = "Male";
            SqlCommand command = new SqlCommand("Select count(*) from SinhVien where gender=@male ", mydb.getConnection);
            command.Parameters.Add("@male", SqlDbType.VarChar).Value = male;
            int totalStd = Convert.ToInt32(command.ExecuteScalar());
            return totalStd;
        }
        public bool deleteStudent(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE from SinhVien WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
