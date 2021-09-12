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
    public partial class AverageGradeWindow : UserControl
    {
        public AverageGradeWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AverageGradeWindow_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSetAverageGrade11);
        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            String conditionStatement = " Order BY AVG(Student_Course.grade) ASC";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            dataSetAverageGrade11.Clear();
            try
            {
                oleDbDataAdapter1.Fill(dataSetAverageGrade11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            String conditionStatement = " Order BY AVG(Student_Course.grade) DESC";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            dataSetAverageGrade11.Clear();
            try
            {
                oleDbDataAdapter1.Fill(dataSetAverageGrade11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT Student.id, Student.name, AVG(Student_Course.grade)"
                + " FROM Student, Student_Course"
                + " WHERE Student.id = Student_Course.student_id AND Student_Course.grade IS NOT NULL AND Student.id = '" + tbxID.Text + "'"
                + " GROUP BY Student.id, Student.name";
            dataSetAverageGrade11.Clear();
            try
            {
                oleDbDataAdapter1.Fill(dataSetAverageGrade11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            if (dataSetAverageGrade11.Tables["Student"].Rows.Count == 0)
            {
                MessageBox.Show("查询无结果。请检查输入的学号或等待出成绩。");
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
        }
    }
}
