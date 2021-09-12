using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private StudentCourseWindow studentCourseWindow;
        private void Form1_Load(object sender, EventArgs e)
        {
            studentCourseWindow = new StudentCourseWindow();
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            studentCourseWindow.Show();
            gpbWindow.Controls.Clear();
            gpbWindow.Controls.Add(studentCourseWindow);
        }
    }
}
