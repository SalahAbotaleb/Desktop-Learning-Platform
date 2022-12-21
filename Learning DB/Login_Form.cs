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
    public partial class Login_Form : KryptonForm
    {
        public Login_Form()
        {
            InitializeComponent();
            //Controller test = new Controller();
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //send 0 for admin
            Credintial C = new Credintial(Definitions.Usertype.admin);
            C.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //send 1 for instructor
            Credintial C = new Credintial(Definitions.Usertype.instructor);
            C.Show();
            this.Hide();
        }
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //send 2 for student
            Credintial C = new Credintial(Definitions.Usertype.student);
            C.Show();
            this.Hide();
        }
    }
}
