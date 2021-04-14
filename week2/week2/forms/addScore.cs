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
    public partial class addScore : Form
    {
        bool flag = false;
        COURSE course = new COURSE();
        public addScore()
        {
            InitializeComponent();
            scoreDropDown.SelectedValueChanged += ScoreDropDown_SelectedValueChanged;
            scoreDropDown.DisplayMember = "courseLabel";
            scoreDropDown.ValueMember = "courseID";
            scoreDropDown.DataSource = course.getAllCourse();
            flag = true;
        }

        private void ScoreDropDown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!flag) return;
            //MessageBox.Show(scoreDropDown.SelectedValue.ToString());
            int cID = (int)scoreDropDown.SelectedValue;
            scoreView.DataSource = course.getStudyIn(cID);
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
            if ((textBoxSId.Text.Trim() == "")  || (textBoxScore.Text.Trim() == "")
                || (textboxScoreDesc.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       

        private void addScore_Load(object sender, EventArgs e)
        {
            scoreDropDown.Text = "Course Options";
        }
    }
}
