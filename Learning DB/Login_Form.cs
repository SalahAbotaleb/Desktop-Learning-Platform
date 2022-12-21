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


        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Credintial C = new Credintial();
            C.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Credintial C = new Credintial();
            C.Show();
        }
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Credintial C = new Credintial();
            C.Show();
            /*StudentInterface student = new StudentInterface();
            student.Show();*/
        }
    }
}
