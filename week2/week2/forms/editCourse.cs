using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week2.model;

namespace week2.forms
{
    public partial class editCourse : Form
    {
        public editCourse()
        {
            InitializeComponent();
            
            comboBoxCourse.DisplayMember = "courseID";
           
           comboBoxCourse.DataSource = course.getAllCourse();
        }
        COURSE course = new COURSE();
        MY_DB mydb = new MY_DB();
        private void editCourse_Load(object sender, EventArgs e)
        {
            comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "courseID";
            comboBoxCourse.ValueMember = "courseID";
            comboBoxCourse.SelectedItem = null;
        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(comboBoxCourse.Text);
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE courseID=@cID ", mydb.getConnection);
            cmd.Parameters.Add("@cID", SqlDbType.VarChar).Value = cID;
           
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                textBoxCName.Text = data.GetValue(1).ToString();
                int cPed = Convert.ToInt32(data.GetValue(2).ToString());
                numericUpDownPeriod.Value = cPed;
                textboxCDesc.Text = data.GetValue(3).ToString();

            }
            mydb.closeConnection();

        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(comboBoxCourse.Text);
            string cLabel = textBoxCName.Text;
            int cped = Convert.ToInt32(numericUpDownPeriod.Value);
            string cDesc = textboxCDesc.Text;
            if (course.updateCourse(cID, cLabel, cped,cDesc))
            {
                MessageBox.Show("Update Course Successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
