using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week2.forms;

namespace week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshBTN.Hide();
        }
        
        private void aDDNEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addStdFrm = new Form2();
            addStdFrm.Show(this);
        }
        STUDENT std = new STUDENT();
        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stdList.DataSource = std.getListStd();
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)stdList.Columns["picture"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            stdList.AllowUserToAddRows = false;
            refreshBTN.Show();
        }

        private void refreshBTN_Click(object sender, EventArgs e)
        {
            stdList.DataSource = std.getListStd();
            DataGridViewImageColumn picInList = (DataGridViewImageColumn)stdList.Columns["picture"];
            picInList.ImageLayout = DataGridViewImageCellLayout.Stretch;
            stdList.AllowUserToAddRows = false;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(searchTXT.Text);
            stdList.DataSource = std.searchSTN(ID);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upDateFrm updateFrm = new upDateFrm();
            updateFrm.Show();
        }

        private void stdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            upDateFrm udFrm = new upDateFrm(stdList.CurrentRow.Cells[0].Value.ToString());
            udFrm.ShowDialog();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticsFrm statFrm = new staticsFrm();
            statFrm.Show();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageSTD mnFrm = new manageSTD();
            mnFrm.Show();
        }

        private void aDDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCourse addCourseFrm = new addCourse();
            addCourseFrm.Show();
        }

        private void mANAGECOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCourse editfrm = new editCourse();
            editfrm.Show();
        }

        private void eDITREMOVECOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove removefrm = new remove();
            removefrm.Show();
        }

        private void pRINTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manageCourse mnFrm = new manageCourse();
            mnFrm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print printFrm = new print(); ;
            printFrm.Show();
        }

        private void pRINTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printCOURSE pcFrm = new printCOURSE();
            pcFrm.Show();
        }

        private void aDDSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addScore asFrm = new addScore();
            asFrm.Show();
        }

        private void aVGSCOREBYCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScore avgFrm = new avgScore();
            avgFrm.Show();
        }

        private void mANAGESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore mncFrm = new ManageScore();
            mncFrm.Show();
        }

        private void rEMOVESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeScore rmsFrm = new removeScore();
            rmsFrm.Show();
        }
    }
}
