using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2.forms
{
    public partial class manageSTD : Form
    {
        public manageSTD()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ResetText();
        }
        STUDENT student = new STUDENT();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
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
                if (student.insertStudent(Id, fname, lname, bdate, gender, phone, adrs, pic))
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
            if ((textBoxFName.Text.Trim() == "") || (textBoxLName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "")
                || (pictureBox1.Image == null))
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            findBtn_Click(null, null);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxId.Text);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adr = textBoxAddress.Text;
            string gender = "Male";
            if (radioButton2.Checked)
            {
                gender = "Female";
            }
            if (student.updateStudent(ID, fname, lname, bdate, gender, phone, adr))
            {
                MessageBox.Show("Update Student Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxId.Text);
            if (student.deleteStudent(ID))
            {
                MessageBox.Show("Delete Student Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        MY_DB mydb = new MY_DB();
        private void findBtn_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxId.Text);
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT fname,lname,bdate,gender,phone,adresss,picture FROM SinhVien WHERE id=@ID ", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                textBoxFName.Text = data.GetValue(0).ToString();
                textBoxLName.Text = data.GetValue(1).ToString();
                dateTimePicker1.Value = data.GetDateTime(2);
                string temp = data.GetString(3).ToString();
                string gder = temp.Trim();
                if (gder == "Male")
                {
                    radioButton1.Checked = true;
                }
                else
                {

                    radioButton2.Checked = true;
                }
                textBoxPhone.Text = data.GetValue(4).ToString();
                textBoxAddress.Text = data.GetValue(5).ToString();
                byte[] pic = (byte[])data.GetValue(6);
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
               
            }
            mydb.closeConnection();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string label = searchTXT.Text;
            stdList.DataSource= student.searchLabel(label);
            totalLb.Text = "Total Student: "+ student.studentCountLb(label).ToString();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxId.Text);
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No img in the picturebox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
