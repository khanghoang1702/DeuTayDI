using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.model
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        public bool insertScore(int sID, int cID, double score, string sDesc)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Score (student_id,course_id,student_score,sdescription)" +
                " VALUES (@sid,@cid,@score,@sdesc)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = sID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = cID;
            command.Parameters.Add("@score", SqlDbType.Float).Value = score;
            command.Parameters.Add("@sdesc", SqlDbType.Text).Value = sDesc;

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
        public DataTable avgScore()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Course.courseLabel, AVG(Score.student_score) as AvarageScore FROM Score, Course " +
                "Where Course.courseID=Score.course_id " +
                "Group by Course.courseLabel ", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable showScore()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Score", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public DataTable showStudent()
        {
            DataTable tbStd = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SV.id, SV.fname, SV.lname, Sc.student_score FROM SinhVien as SV, Score as Sc WHERE SV.id=Sc.student_id", mydb.getConnection);
            SqlDataAdapter dataStd = new SqlDataAdapter(cmd);
            dataStd.Fill(tbStd);
            return tbStd;
        }
        public bool deleteCourse(int sID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM dbo.Score WHERE student_id=@sID", mydb.getConnection);
            command.Parameters.Add("@sID", SqlDbType.Int).Value = sID;
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
