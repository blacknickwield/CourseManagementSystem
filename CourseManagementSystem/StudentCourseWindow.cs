using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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
            oleDbDataAdapter1.Fill(dataSetStudent11);
            oleDbDataAdapter3.Fill(dataSetCourse11);
        }

        

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            // 查询学生个人信息
            String conditionStatement1 = " WHERE id = '" + tbxIDSearch.Text + "'";
            String originSelectCommand1 = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand1 + conditionStatement1;
            dataSetStudent11.Clear();
            try
            {
                oleDbDataAdapter1.Fill(dataSetStudent11);
            }
            catch (Exception execption)
            {
                MessageBox.Show(execption.Message);
            }
            if (dataSetStudent11.Tables["Student"].Rows.Count <= 0)
            {
                MessageBox.Show("未找到学生信息。请检查输入的学生学号是否正确。");
                oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand1;
                return;
            }

            // 显示学生个人信息
            MessageBox.Show(dataSetStudent11.Tables["Student"].Rows[0]["name"].ToString());
            tbxID.Text = dataSetStudent11.Tables["Student"].Rows[0]["id"].ToString();
            tbxName.Text = dataSetStudent11.Tables["Student"].Rows[0]["name"].ToString();
            tbxGender.Text = dataSetStudent11.Tables["Student"].Rows[0]["gender"].ToString();
            tbxAge.Text = dataSetStudent11.Tables["Student"].Rows[0]["age"].ToString();
            tbxClass.Text = dataSetStudent11.Tables["Student"].Rows[0]["class"].ToString();
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand1;

            // 查询当前学生已选的课
            String conditionStatement2 = " AND Student_Course.student_id = '" + tbxIDSearch.Text + "'";
            String originSelectCommand2 = oleDbDataAdapter2.SelectCommand.CommandText;
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand2 + conditionStatement2;
            dataSetCourseSelected11.Clear();
            try
            {
                oleDbDataAdapter2.Fill(dataSetCourseSelected11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand2;


            // 查询当前学生可选的课
            String conditionStatement3 = " AND Course.id NOT IN " +
                "(SELECT SC.course_id FROM Student_Course AS SC WHERE SC.student_id = '" + tbxIDSearch.Text + "')";
            String originSelectCommand3 = oleDbDataAdapter3.SelectCommand.CommandText;
            oleDbDataAdapter3.SelectCommand.CommandText = originSelectCommand3 + conditionStatement3;
            dataSetCourse11.Clear();
            try
            {
                oleDbDataAdapter3.Fill(dataSetCourse11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter3.SelectCommand.CommandText = originSelectCommand3;
        }

        // 退课
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow oldRow = dataSetCourseSelected11.Tables["ClassRoom"].Rows[dataGridView1.CurrentRow.Index];
            if (!(oldRow["Grade"].ToString() == null || oldRow["Grade"].ToString().Length == 0))
            {
                MessageBox.Show("该课程已登记成绩，不能退课！");
                return;
            }
            //MessageBox.Show(dataSetCourseSelected11.Tables["ClassRoom"].Rows[dataGridView1.CurrentRow.Index]["ID"].ToString());
            DataRow newRow = dataSetCourse11.Tables["ClassRoom"].NewRow();
            newRow["ID"] = oldRow["ID"];
            newRow["Course Name"] = oldRow["Course Name"];
            newRow["Credit"] = oldRow["Credit"];
            newRow["Time"] = oldRow["Time"];
            newRow["Teacher Name"] = oldRow["Teacher Name"];
            newRow["Room Name"] = oldRow["Room Name"];
            //newRow["Grade"] = oldRow["Grade"];
            int index = dataSetCourse11.Tables["ClassRoom"].Rows.Count + 1;
            //MessageBox.Show(index.ToString());
            dataSetCourse11.Tables["ClassRoom"].Rows.InsertAt(newRow, index);
            courseDeletedList.Add(oldRow["ID"]);
            dataSetCourseSelected11.Tables["ClassRoom"].Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
        
        // 选课
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow oldRow = dataSetCourse11.Tables["ClassRoom"].Rows[dataGridView2.CurrentRow.Index];
            DataRow newRow = dataSetCourseSelected11.Tables["ClassRoom"].NewRow();
            newRow["ID"] = oldRow["ID"];
            newRow["Course Name"] = oldRow["Course Name"];
            newRow["Credit"] = oldRow["Credit"];
            newRow["Time"] = oldRow["Time"];
            newRow["Teacher Name"] = oldRow["Teacher Name"];
            newRow["Room Name"] = oldRow["Room Name"];
            int index = dataSetCourseSelected11.Tables["ClassRoom"].Rows.Count + 1;
            dataSetCourseSelected11.Tables["ClassRoom"].Rows.InsertAt(newRow, index);
            courseAddedList.Add(oldRow["ID"]);
            dataSetCourse11.Tables["ClassRoom"].Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }
        private ArrayList courseDeletedList = new ArrayList();

        private ArrayList courseAddedList = new ArrayList();

    }
    
}
