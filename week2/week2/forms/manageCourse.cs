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
    public partial class manageCourse : Form
    {
        MY_DB mydb = new MY_DB();
        public manageCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void searchBTN_Click(object sender, EventArgs e)
        {
            string label = searchTXT.Text;
            courseList.DataSource = course.courseSearchLb(label);
            labelTotal.Text = "Total Course: " + course.courseCountLb(label).ToString();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(textBoxCId.Text);
            mydb.openConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE courseID=@cID ", mydb.getConnection);
            cmd.Parameters.Add("@cID", SqlDbType.VarChar).Value = cID;
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                textBoxLabel.Text = data.GetValue(1).ToString();
                textBoxPeriod.Text = data.GetValue(2).ToString();
                textBoxDesc.Text = data.GetValue(3).ToString();

            }
            mydb.closeConnection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int cid = Convert.ToInt32(textBoxCId.Text);
            string cLabel = textBoxLabel.Text;
            int cPed = Convert.ToInt32(textBoxPeriod.Text);
            string cDesc = textBoxDesc.Text;
            if ((cPed < 10))
            {
                MessageBox.Show("The Course Time must be greater than 10", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (verif())
            {
                if (course.insertCourse(cid, cLabel, cPed, cDesc))
                {
                    MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxCId.Text.Trim() == "") || (textBoxLabel.Text.Trim() == "")
                || (textBoxPeriod.Text.Trim() == "") || (textBoxDesc.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(textBoxCId.Text);
            string cLabel = textBoxLabel.Text;
            int cped = Convert.ToInt32(textBoxPeriod.Text);
            string cDesc = textBoxDesc.Text;
            if (course.updateCourse(cID, cLabel, cped, cDesc))
            {
                MessageBox.Show("Update Course Successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt32(textBoxCId.Text);
            if (course.deleteCourse(cID))
            {
                MessageBox.Show("Delete Course Successfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }

