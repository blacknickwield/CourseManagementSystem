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
    public partial class CourseGradeWindow : UserControl
    {
        public CourseGradeWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // 根据课程号查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String conditionStatement1 = " AND Course.id = '" + tbxID.Text + "'";
            String originSelectCommand1 = oleDbDataAdapter2.SelectCommand.CommandText;
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand1 + conditionStatement1;
            dataSetQueryCourse11.Clear();
            try
            {
                oleDbDataAdapter2.Fill(dataSetQueryCourse11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            if (dataSetQueryCourse11.Tables["Course"].Rows.Count <= 0)
            {
                MessageBox.Show("未查询到该课程的信息。请检查输入的课程号。");
                oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand1;
                return;
            }
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand1;
            tbxCourseName.Text = dataSetQueryCourse11.Tables["Course"].Rows[0]["name"].ToString();
            tbxCourseCredit.Text = dataSetQueryCourse11.Tables["Course"].Rows[0]["credit"].ToString();
            tbxCourseTeacher.Text = dataSetQueryCourse11.Tables["Course"].Rows[0]["Teacher Name"].ToString();

            //TODO
            dataSetCourseGrade11.Clear();
            dataSetCourseGrade21.Clear();
            dataSetCourseGrade31.Clear();
            dataSetCourseGrade41.Clear();
            dataSetCourseGrade51.Clear();
            String conditionStatement = " AND Student_Course.course_id = '" + tbxID.Text + "'";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            MessageBox.Show(oleDbDataAdapter1.SelectCommand.CommandText);
            excellentSearch();
            goodSearch();
            middleSearch();
            passSearch();
            failSearch();
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            totalNumber = excellentNumber + goodNumber + middleNumber + passNumber + failNumber;
            if (totalNumber == 0)
            {
                tbxExcellentPercent.Text = "0%";
                tbxGoodPercent.Text = "0%";
                tbxMiddlePercent.Text = "0%";
                tbxPassPercent.Text = "0%";
                tbxFailPercent.Text = "0%";
            }
            else
            {
                tbxExcellentPercent.Text = (excellentNumber * 100 / totalNumber).ToString() + "%";
                tbxGoodPercent.Text = (goodNumber * 100 / totalNumber).ToString() + "%";
                tbxMiddlePercent.Text = (middleNumber * 100 / totalNumber).ToString() + "%";
                tbxPassPercent.Text = (passNumber * 100 / totalNumber).ToString() + "%";
                tbxFailPercent.Text = (failNumber * 100 / totalNumber).ToString() + "%";
            }
            
        }

        private void excellentSearch()
        {
            String conditionStatement = " AND Student_Course.grade >= 90 AND Student_Course.grade <= 100";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourseGrade11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            excellentNumber = dataSetCourseGrade11.Tables["Student_Course"].Rows.Count;
            tbxExcellentNumber.Text = excellentNumber.ToString();
        }

        private void goodSearch()
        {
            String conditionStatement = " AND Student_Course.grade >= 80 AND Student_Course.grade < 90";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourseGrade21);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            goodNumber = dataSetCourseGrade21.Tables["Student_Course"].Rows.Count;
            tbxGoodNumber.Text = goodNumber.ToString();
        }

        private void middleSearch()
        {
            String conditionStatement = " AND Student_Course.grade >= 70 AND Student_Course.grade < 80";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourseGrade31);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            middleNumber = dataSetCourseGrade31.Tables["Student_Course"].Rows.Count;
            tbxMiddleNumber.Text = middleNumber.ToString();
        }

        private void passSearch()
        {
            String conditionStatement = " AND Student_Course.grade >= 60 AND Student_Course.grade < 70";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourseGrade41);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            passNumber = dataSetCourseGrade41.Tables["Student_Course"].Rows.Count;
            tbxPassNumber.Text = passNumber.ToString();
        }

        private void failSearch()
        {
            String conditionStatement = " AND Student_Course.grade >= 0 AND Student_Course.grade < 60";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourseGrade51);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
            failNumber = dataSetCourseGrade51.Tables["Student_Course"].Rows.Count;
            tbxFailNumber.Text = failNumber.ToString();
        }

        private int excellentNumber = 0;
        private int goodNumber = 0;
        private int middleNumber = 0;
        private int passNumber = 0;
        private int failNumber = 0;
        private int totalNumber = 0;

        private void CourseGradeWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
