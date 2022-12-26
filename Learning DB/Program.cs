using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbHandler;

namespace Learning_DB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //OpenedSession.ID = 50002;
            //Application.Run(new StudentClassroom(7,50002));
            //Application.Run(new AdminInterface());
            OpenedSession.ID = 8;
            //Application.Run(new AdminInterface());
            //Application.Run(new StudentClassroom(17,50002));
            //Application.Run(new Credintial());
            //Application.Run(new Sign_Up());
            //Application.Run(new Login_Form());
            Application.Run(new InstructorReports());

            //Application.Run(new triaal());
            //Application.Run(new triaal());
        }
    }
}
