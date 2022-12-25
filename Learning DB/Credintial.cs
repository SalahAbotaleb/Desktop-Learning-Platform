using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbHandler;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using MetroSet_UI.Enums;
using System.Net;

namespace Learning_DB
{
    public partial class Credintial : KryptonForm
    {
        Controller con;
        public Credintial()
        {
            InitializeComponent();
            con = new Controller();
            Invalid_message.Visible = false;
        }


        private void Username_Enter(object sender, EventArgs e)
        {
            Invalid_message.Hide();
            if (UsernameBox.Text == "Username/Email")
            {
                UsernameBox.Text = "";
                UsernameBox.StateCommon.Content.Color1 = Color.Black;
                UsernameBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular);
            }

        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username/Email";
                UsernameBox.StateCommon.Content.Color1 = Color.Gray;
                UsernameBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Italic);
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            Invalid_message.Hide();
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.PasswordChar = '*';
                PasswordBox.StateCommon.Content.Color1 = Color.Black;
                PasswordBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Regular);

            }
        }
        
        private void Password_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.PasswordChar = '\0';
                PasswordBox.Text = "Password";
                PasswordBox.StateCommon.Content.Color1 = Color.Gray;
                PasswordBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Italic);
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(OpenedSession.User == Usertype.instructor)
            {
                Tuple<DataTable, string> ins = con.LoginInstructor(UsernameBox.Text, PasswordBox.Text);
                if(ins.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                //instructor interface
                OpenedSession.ID = Convert.ToInt32(ins.Item1.Rows[0]["Instructor_ID"]);
                OpenedSession.UserData = ins.Item1;
                Inst1 i = new Inst1(10004);//hardcoded
                i.Show();
            }
            else if (OpenedSession.User == Usertype.student)
            {
                Tuple<DataTable,string> st = con.LoginStudent(UsernameBox.Text, PasswordBox.Text);
                if (st.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                //studentinterface
                OpenedSession.ID = Convert.ToInt32(st.Item1.Rows[0]["StudentID"]);
                OpenedSession.UserData = st.Item1;
                StudentClasses s = new StudentClasses();
                s.Show();
                this.Hide();
            }
            else
            {
                Tuple<DataTable, string> ad = con.LoginAdmin(UsernameBox.Text, PasswordBox.Text);
                if (ad.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                //admin interface
                OpenedSession.ID = Convert.ToInt32(ad.Item1.Rows[0]["Admin_ID"]);
                OpenedSession.UserData = ad.Item1;
                AdminInterface A = new AdminInterface();
                A.Show();
                this.Hide();
            }
        }
        
        private void Credintial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Credintial_Load(object sender, EventArgs e)
        {
            kryptonLabel1.Select();
        }
        
        private void gobackbutton_Click(object sender, EventArgs e)
        {
            Login_Form l = new Login_Form();
            l.Show();
            this.Hide();
        }
    }
}
