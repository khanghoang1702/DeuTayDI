using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week2.model;

namespace week2.forms
{
    public partial class ManageScore : Form
    {
        bool flag = false;
        COURSE course = new COURSE();
        public ManageScore()
        {
            InitializeComponent();
            scoreDropDown.SelectedValueChanged += ScoreDropDown_SelectedValueChanged; ;
            scoreDropDown.DisplayMember = "courseLabel";
            scoreDropDown.ValueMember = "courseID";
            scoreDropDown.DataSource = course.getAllCourse();
            flag = true;
        }

        private void ScoreDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!flag) return;
        }
        SCORE score1 = new SCORE();
        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt32(textBoxSId.Text);
            //int cID = Convert.ToInt32(textBoxCid.Text);
            float score = float.Parse(textBoxScore.Text);
            string sDesc = textboxScoreDesc.Text;
            try
            {
                if (verif())
                {
                    if (score1.insertScore(sID, 1, score, sDesc))
                    {
                        MessageBox.Show("Student Score Added", "Add Student Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("The student or course does not exist", "Add Student Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxSId.Text.Trim() == "") || (textBoxScore.Text.Trim() == "")
                || (textboxScoreDesc.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAVG_Click(object sender, EventArgs e)
        {
            scoreView.DataSource = score1.avgScore();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            scoreView.DataSource = score1.showScore();
        }

        private void showSTDBTN_Click(object sender, EventArgs e)
        {
            scoreView.DataSource = score1.showStudent();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt32(textBoxSId.Text);
            if (course.deleteCourse(sID))
            {
                MessageBox.Show("Delete Score Successfully", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {

        }

        private void scoreView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
