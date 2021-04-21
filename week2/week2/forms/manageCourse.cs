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
                    listboxCourse();
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
        private void listboxCourse()
        {
            lbCourse.DataSource = course.getAllCourse();
            lbCourse.ValueMember = "courseID";
            lbCourse.DisplayMember = "courseLabel";
            lbCourse.SelectedItem = null;
            labelTotal.Text=("Total course: " + course.courseCount());
        }

        private void manageCourse_Load(object sender, EventArgs e)
        {
            listboxCourse();
        }
        private void getCourse(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            lbCourse.SelectedIndex = index;
            textBoxCId.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();
            textBoxPeriod.Text = dr.ItemArray[2].ToString();
            textBoxDesc.Text = dr.ItemArray[3].ToString();
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            //DataRowView drv = (DataRowView)lbCourse.SelectedItem;
            int pos = lbCourse.SelectedIndex;
            getCourse(pos);
        }
    }
 }

