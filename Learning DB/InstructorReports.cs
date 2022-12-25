using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Learning_DB
{
    public partial class InstructorReports : KryptonForm
    {
        int Student_ID;
        //TODO ya zahar
        public InstructorReports()
        {
            InitializeComponent();
            InstructorStatistics.SelectedIndex = 0;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            InstructorStatistics.SelectedIndex = 1;

        }
    }
}
