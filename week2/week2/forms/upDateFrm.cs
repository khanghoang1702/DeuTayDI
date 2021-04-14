using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class upDateFrm : Form
    {
        public upDateFrm()
        {
            InitializeComponent();
        }
        public upDateFrm(string ID)
        {
            InitializeComponent();
            idETB.Text = ID;
        }
        STUDENT std = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            int ID = int.Parse(idETB.Text);
            mydb.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT fname,lname,bdate,gender,phone,adresss,picture FROM SinhVien WHERE id=@ID ", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
            SqlDataReader data = cmd.ExecuteReader();
            while(data.Read())
            {
                fnameETB.Text = data.GetValue(0).ToString();
                lnameETB.Text= data.GetValue(1).ToString();
                dtimeE.Value = data.GetDateTime(2);
                string temp = data.GetString(3).ToString();
                string gder = temp.Trim();
                if (gder == "Male")
                {
                    mRBTN.Checked = true;
                }
                else
                {
                   
                    fRBTN.Checked = true;
                }
                phoneETB.Text= data.GetValue(4).ToString();
                addressETB.Text= data.GetValue(5).ToString();
                byte[] pic = (byte[])data.GetValue(6);
                MemoryStream picture = new MemoryStream(pic );
                pictuteE.Image = Image.FromStream(picture);
            }

        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(idETB.Text);
            string fname = fnameETB.Text;
            string lname = lnameETB.Text;
            DateTime bdate = dtimeE.Value;
            string phone = phoneETB.Text;   
            string adr = addressETB.Text;
            string gender = "Male";
            if (fRBTN.Checked)
            {
                gender = "Female";
            }
            if (std.updateStudent(ID, fname, lname, bdate,gender, phone, adr))
            {
                MessageBox.Show("Update Student Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(idETB.Text);
            if (std.deleteStudent(ID))
            {
                MessageBox.Show("Delete Student Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
