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
    public partial class addCourse : Form
    {
        public addCourse()
        {
            InitializeComponent();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            int cid= Convert.ToInt32(textBoxCId.Text);
            string cLabel = textBoxCName.Text;
            int cPed = Convert.ToInt32(textBoxCPed.Text);
            string cDesc = textboxCDesc.Text;
            if ((cPed<10))
            {
                MessageBox.Show("The Course Time must be greater than 10", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          else if (verif())
            {
                if (course.insertCourse(cid,cLabel, cPed, cDesc))
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
                if ((textBoxCId.Text.Trim()=="")||(textBoxCName.Text.Trim() == "") || (textBoxCName.Text.Trim() == "")
                    || (textBoxCPed.Text.Trim() == "")||(textboxCDesc.Text.Trim()==""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        private void textBoxCId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxCDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

