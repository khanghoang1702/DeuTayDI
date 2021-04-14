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
    public partial class avgScore : Form
    {
        public avgScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void avgScore_Load(object sender, EventArgs e)
        {
            avgView.DataSource = score.avgScore();
        }
    }
}
