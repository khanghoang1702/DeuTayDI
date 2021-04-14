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
    public partial class removeScore : Form
    {
        SCORE score1 = new SCORE();
        public removeScore()
        {
            InitializeComponent();
        }

        private void removeScore_Load(object sender, EventArgs e)
        {
            scoreView.DataSource = score1.showScore();
        }

        private void rmBTN_Click(object sender, EventArgs e)
        {
            int sID =Convert.ToInt32(scoreView.SelectedCells[0].Value);
            score1.deleteCourse(sID);
            scoreView.DataSource = score1.showScore();
        }

        private void scoreView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1)
            //{
            //    DataGridViewRow dvgs = scoreView.Rows[e.RowIndex];
            //    int sID = (int)dvgs.Cells[0].Value;

            //}
        }
    }
}
