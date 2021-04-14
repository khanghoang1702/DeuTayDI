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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
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
