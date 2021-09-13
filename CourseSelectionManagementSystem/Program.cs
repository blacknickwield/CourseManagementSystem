using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelectionManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 form1 = new Form1();
            form1.ShowDialog();

            if (form1.DialogResult == DialogResult.OK)
            {
                String studentID = form1.StudentID;
                String name = form1.Name;
                String password = form1.Password;
                form1.Dispose();
                Application.Run(new MainWindow(studentID, password, name));
            }
            else
            {

            }
        }
    }
}
