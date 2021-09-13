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
        private StudentGradeWindow studentGradeWindow;
        private AverageGradeWindow averageGradeWindow;
        private CourseGradeWindow courseGradeWindow;
        private void Form1_Load(object sender, EventArgs e)
        {
            studentCourseWindow = new StudentCourseWindow();
            studentGradeWindow = new StudentGradeWindow();
            averageGradeWindow = new AverageGradeWindow();
            courseGradeWindow = new CourseGradeWindow();
        }

        private void btnStudentCourse_Click(object sender, EventArgs e)
        {
            studentCourseWindow.Show();
            gpbWindow.Controls.Clear();
            gpbWindow.Controls.Add(studentCourseWindow);
        }

        private void btnAverageGrade_Click(object sender, EventArgs e)
        {
            averageGradeWindow.Show();
            gpbWindow.Controls.Clear();
            gpbWindow.Controls.Add(averageGradeWindow);
        }

        private void btnCourseGrade_Click(object sender, EventArgs e)
        {
            courseGradeWindow.Show();
            gpbWindow.Controls.Clear();
            gpbWindow.Controls.Add(courseGradeWindow);
        }

        private void btnGradeUpdate_Click(object sender, EventArgs e)
        {
            studentGradeWindow.Show();
            gpbWindow.Controls.Clear();
            gpbWindow.Controls.Add(studentGradeWindow);
        }
    }
}
