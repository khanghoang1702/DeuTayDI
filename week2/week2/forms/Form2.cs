using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int Id = Convert.ToInt32(textBoxId.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAddress.Text;
            string gender = "Male";
            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (student.insertStudent(Id, fname, lname, bdate,gender,phone,adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if((textBoxFName.Text.Trim()=="")||(textBoxLName.Text.Trim()=="")
                ||(textBoxAddress.Text.Trim()=="")||(textBoxPhone.Text.Trim()=="")
                ||(pictureBox1.Image==null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonIMG_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
