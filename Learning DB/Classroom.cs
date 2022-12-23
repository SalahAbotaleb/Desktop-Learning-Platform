using DbHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_DB
{
    public partial class Classroom : Form
    {
        Controller c;
        int Classroom_ID;
        public Classroom(int C_ID)
        {
            Classroom_ID= C_ID; 
            InitializeComponent();
            c = new Controller();
            DataTable dt = new DataTable();
            dt = c.SelectClassroomByID(Classroom_ID);
            kryptonTextBox14.Text = dt.Rows[0]["Title"].ToString() ;
            kryptonTextBox15.Text = dt.Rows[0]["Access_code"].ToString() ;
            
        }

        private void copyaccesscode_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(kryptonTextBox14.Text);
        }

        private void kryptonTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
