using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2
{
    public partial class logInFrm : Form
    {
        public logInFrm()
        {
            InitializeComponent();
        }

        private void logInBTN_Click(object sender, EventArgs e)
        {
            user u = new user();
            string account = accTXTBox.Text;
            string pw = pwTXTBox.Text;
            bool valid = u.checkLogIn(account, pw);
            if (valid)
            {
                Form1 mainFrm = new Form1();
                this.Hide();
                mainFrm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorInput.SetError(accTXTBox, "Please input your account");
                errorInput.SetError(pwTXTBox, "Please input your password");
            }
        }

        private void regisBTN_Click(object sender, EventArgs e)
        {
            user u = new user();
            string account = accTXTBox.Text;
            string pw = pwTXTBox.Text;
            bool valid = u.insertUser(account, pw);
            if (valid)
            {
                MessageBox.Show("New User Added", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logInFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
