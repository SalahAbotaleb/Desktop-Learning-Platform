using System;
using System.Collections.Generic;
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
            Controller c=new Controller();
            Exam ex = new Exam(50002, 3, c);
            string st =ex.getCurrQuesDescription();
            string[] list = ex.getCurrQuesOptions();
            ex.InsertAnswer(0);
            ex.InsertAnswer(1);
            ex.submitExam();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentClassroom(7,50002));
        }
    }
}
