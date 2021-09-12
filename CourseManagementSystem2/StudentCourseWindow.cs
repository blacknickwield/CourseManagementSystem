using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
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
            this.oleDbDataAdapter3.Fill(this.dataSet11);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Int32 studentID = Int32.Parse(tbxSearchID.Text);
            //MessageBox.Show(studentID.ToString());
            //String sqlStudentCourseSelect = "SELECT id, name, credit, time, teacher_id, classroom_id " +
            //    "FROM Course WHERE id = " + studentID.ToString();
            MessageBox.Show(oleDbSelectCommand3.CommandText);
            String sqlStudentCourseSelect = "SELECT id, name, credit, time, teacher_id, classroom_id " +
                "FROM Course WHERE id = '" + tbxSearchID.Text + "'";
            MessageBox.Show(sqlStudentCourseSelect);
            OleDbCommand cmdStudentCourseSelect = new OleDbCommand(sqlStudentCourseSelect);
            cmdStudentCourseSelect.Connection = oleDbConnection1;
            this.oleDbConnection1.Open();
            cmdStudentCourseSelect.ExecuteNonQuery();
            this.oleDbConnection1.Close();

            this.dataSet11.Clear();
            this.oleDbDataAdapter3.Fill(dataSet11);
            MessageBox.Show(oleDbSelectCommand3.CommandText);
        }
    }
}
