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
        Usertype utype;
        Controller con;
        public Credintial(Usertype user)
        {
            InitializeComponent();
            con = new Controller();
            utype = user;
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
        //private Boolean ValidateUsername()
        //{ 
        //    //validate text in usernamebox to see if in valid email format
        //    if(UsernameBox.Text.Contains("@"))
        //    {

        //    }
        //    return true;
        //}
        
        //bool valid = true; // for validation (will be changed in future validation in username and password)
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(utype == Usertype.instructor)
            {
                Tuple<DataTable, string> ins = con.LoginInstructor(UsernameBox.Text, PasswordBox.Text);
                if(ins.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                //instructor interface
            }
            else if (utype== Usertype.student)
            {
                Tuple<DataTable,string> st = con.LoginStudent(UsernameBox.Text, PasswordBox.Text);
                if (st.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                //studentinterface
            }
            else
            {
                Tuple<DataTable, string> ad = con.LoginAdmin(UsernameBox.Text, PasswordBox.Text);
                if (ad.Item1 == null)
                {
                    Invalid_message.Show();
                    return;
                }
                AdminInterface A = new AdminInterface();
                A.Show();
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
    }
}
