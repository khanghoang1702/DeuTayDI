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
    public partial class staticsFrm : Form
    {
        STUDENT std = new STUDENT();
        public staticsFrm()
        {
            InitializeComponent();
            double totalStd = std.studentStatics();
            double totalMale = std.maleCount();
            double totalFemale = std.femaleCount();
            double malePercetage = (totalMale * (100 / totalStd));
            double fmalePercetage = 100-malePercetage;
            totalLabel.Text = totalStd.ToString();
            maleLabel.Text = malePercetage.ToString("0.00") + "%";
            fmaleLabel.Text = fmalePercetage.ToString("0.00" )+ "%";
        }

    }
}
