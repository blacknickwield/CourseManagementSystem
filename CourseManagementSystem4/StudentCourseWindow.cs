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
    public partial class StudentCourseWindow : UserControl
    {
        public StudentCourseWindow()
        {
            InitializeComponent();
        }

        private void StudentCourseWindow_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter2.Fill(dataSet21);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter2.SelectCommand.CommandText = "SELECT Course.id, Course.name, Course.credit, Course.[time], Student_Course.grade, Student_Course.student_id"
                + " FROM Student_Course INNER JOIN"
          + " Course ON Student_Course.course_id = Course.id INNER JOIN"
          + " Student ON Student_Course.student_id = Student.id"
          + " WHERE Course.id= '" + tbxIDSearch.Text + "'";
            MessageBox.Show(oleDbDataAdapter2.SelectCommand.CommandText);
            oleDbDataAdapter2.Update(dataSet21);
            dataSet21.Clear();
            
            //oleDbDataAdapter2.Fill(dataSet21);
            //oleDbDataAdapter2.Fill(dataSet21);
        }
    }
}
