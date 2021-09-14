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
using System.Data.OleDb;
namespace CourseSelectionManagementSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void windowUpdate()
        {
            selectedCourseNumber = dataSetSelectedCourse11.Tables["Course"].Rows.Count;
            labelTotalNumber.Text = selectedCourseNumber.ToString();
            //labelTotalNumber.Text = selectedCourseNumber.ToString();
            //labelTotalCredit.Text = selectedCreditNumber.ToString();


            bool courseCheck = false;

            int courseAvailableMin = courseNumberMin - selectedCourseNumber;
            int courseAvailableMax = courseNumberMax - selectedCourseNumber;

            if (courseAvailableMin > 0)
            {
                labelCourseAvailable.Text = "你已选择" + selectedCourseNumber.ToString() + "门课程，"
                    + "还需选至少" + courseAvailableMin.ToString() + "门课程";
                labelCourseAvailable.ForeColor = Color.Red;
            }
            else if (courseAvailableMax >= 0)
            {
                labelCourseAvailable.Text = "你已选择" + selectedCourseNumber.ToString() + "门课程，"
                    + "还可再选" + courseAvailableMax.ToString() + "门课程";
                labelCourseAvailable.ForeColor = Color.Green;
                courseCheck = true;
            }
            else
            {
                labelCourseAvailable.Text = "你选择的课程已超过数量上限，请先进行退课";
                labelCourseAvailable.ForeColor = Color.Red;
            }


            int creditTotal = 0;
            for (int i = 0; i < dataSetSelectedCourse11.Tables["Course"].Rows.Count; i++)
            {
                creditTotal += Int32.Parse(dataSetSelectedCourse11.Tables["Course"].Rows[i]["Credit"].ToString());
            }
            labelTotalCredit.Text = creditTotal.ToString();
            selectedCreditNumber = creditTotal;

            
            bool creditCheck = false;
            int creditAvailableMin = creditTotalMin - selectedCreditNumber;
            int creditAvailableMax = creditTotalMax - selectedCreditNumber;

            if (creditAvailableMin > 0)
            {
                labelCreditAvailable.Text = "您已选修" + selectedCreditNumber.ToString() + "学分," 
                    +"还需选修至少" + creditAvailableMin.ToString() + "学分";
                labelCreditAvailable.ForeColor = Color.Red;
            }
            else if (creditAvailableMax >= 0)
            {
                labelCreditAvailable.Text = "您已选修" + selectedCreditNumber.ToString() + "学分,"
                    + "还可再选修" + creditAvailableMax + "学分";
                labelCreditAvailable.ForeColor = Color.Green;
                creditCheck = true;
            }
            else
            {
                labelCreditAvailable.Text = "您选修的学分已超过学分上限，请进行调整";
                labelCreditAvailable.ForeColor = Color.Red;
            }

            if (courseCheck && creditCheck)
            {
                labelHint.Text = "你的选课满足要求\n\n"
                    + "可以进行提交";
                labelHint.ForeColor = Color.Green;
                btnSubmit.Enabled = true;
            }
            else
            {
                labelHint.Text = "您的选课不满足要求\n\n"
                    + "不可进行提交";
                labelHint.ForeColor = Color.Red;
                btnSubmit.Enabled = false;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tbxStudentID.Text = studentID;
            tbxName.Text = name;
            labelTitle.Text = "你好，" + name
                + "\n欢迎来到选课管理系统";
            // 查询当前学生可选的课
            String conditionStatement1 = " AND Course.id NOT IN " +
                "(SELECT SC.course_id FROM Student_Course AS SC WHERE SC.student_id = '" + studentID + "')";
            String originSelectCommand1 = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand1 + conditionStatement1;
            dataSetCourse11.Clear();
            try
            {
                oleDbDataAdapter1.Fill(dataSetCourse11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand1;

            // 查询当前学生已选的课
            String conditionStatement2 = " AND Student_Course.student_id = '" + studentID + "'";
            String originSelectCommand2 = oleDbDataAdapter2.SelectCommand.CommandText;
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand2 + conditionStatement2;
            dataSetSelectedCourse11.Clear();
            try
            {
                oleDbDataAdapter2.Fill(dataSetSelectedCourse11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            selectedCourseNumber = dataSetSelectedCourse11.Tables["Course"].Rows.Count;
            labelTotalNumber.Text = selectedCourseNumber.ToString();
            int totalCredit = 0;
            for (int i = 0; i < dataSetSelectedCourse11.Tables["Course"].Rows.Count; i++)
            {
                totalCredit += Int32.Parse(dataSetSelectedCourse11.Tables["Course"].Rows[i]["Credit"].ToString());
            }
            selectedCreditNumber = totalCredit;
            labelTotalCredit.Text = selectedCreditNumber.ToString();
            oleDbDataAdapter2.SelectCommand.CommandText = originSelectCommand2;

            courseOriginList.Clear();
            for (int i = 0; i < dataSetSelectedCourse11.Tables["Course"].Rows.Count; i++)
            {
                courseOriginList.Add(dataSetSelectedCourse11.Tables["Course"].Rows[i]["ID"]);
            }

            windowUpdate();
        }

        public MainWindow(string studentID, string password, string name)
        {
            this.studentID = studentID;
            this.password = password;
            this.name = name;
            InitializeComponent();
        }
        private string studentID = null;
        private string password = null;
        private string name = null;

        private int selectedCourseNumber = 0;
        private int selectedCreditNumber = 0;

        private const int courseNumberMin = 3;
        private const int courseNumberMax = 5;

        private const int creditTotalMin = 8;
        private const int creditTotalMax = 12;
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null 
                || dataSetSelectedCourse11.Tables["Course"].Rows[dataGridView2.CurrentRow.Index]["ID"].ToString().Length <= 0)
            {
                MessageBox.Show("未选中课程");
                return;
            }
            //MessageBox.Show(dataGridView2.CurrentRow.Index.ToString());
            //MessageBox.Show(dataSetSelectedCourse11.Tables["Course"].Rows[dataGridView2.CurrentRow.Index]["ID"].ToString());
            DataRow oldRow = dataSetSelectedCourse11.Tables["Course"].Rows[dataGridView2.CurrentRow.Index];
            DataRow newRow = dataSetCourse11.Tables["Course"].NewRow();
            newRow["ID"] = oldRow["ID"];
            newRow["Course Name"] = oldRow["Course Name"];
            newRow["Credit"] = oldRow["Credit"];
            newRow["Time"] = oldRow["Time"];
            newRow["Teacher Name"] = oldRow["Teacher Name"];
            int index = dataSetCourse11.Tables["Course"].Rows.Count + 1;
            dataSetCourse11.Tables["Course"].Rows.InsertAt(newRow, index);
            if (!courseRemovedList.Contains(oldRow["ID"]))
                courseRemovedList.Add(oldRow["ID"]);
            if (courseSelectedList.Contains(oldRow["ID"]))
                courseSelectedList.Remove(oldRow["ID"]);
            //textBox1.Text = courseSelectedList.Count.ToString();
            //textBox2.Text = courseRemovedList.Count.ToString();
            dataSetSelectedCourse11.Tables["Course"].Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            windowUpdate();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null 
                || dataSetCourse11.Tables["Course"].Rows[dataGridView1.CurrentRow.Index]["ID"].ToString().Length <= 0)
            {
                MessageBox.Show("未选中课程");
                return;
            }
                
            DataRow oldRow = dataSetCourse11.Tables["Course"].Rows[dataGridView1.CurrentRow.Index];
            //DataRow testRow = dataGridView1.CurrentRow;
            DataRow newRow = dataSetSelectedCourse11.Tables["Course"].NewRow();
            newRow["ID"] = oldRow["ID"];
            newRow["Course Name"] = oldRow["Course Name"];
            newRow["Credit"] = oldRow["Credit"];
            newRow["Time"] = oldRow["Time"];
            newRow["Teacher Name"] = oldRow["Teacher Name"];
            int index = dataSetSelectedCourse11.Tables["Course"].Rows.Count + 1;
            dataSetSelectedCourse11.Tables["Course"].Rows.InsertAt(newRow, index);
            if (!courseSelectedList.Contains(oldRow["ID"]))
                courseSelectedList.Add(oldRow["ID"]);
            if (courseRemovedList.Contains(oldRow["ID"]))
                courseRemovedList.Remove(oldRow["ID"]);
            //textBox1.Text = courseSelectedList.Count.ToString();
            //textBox2.Text = courseRemovedList.Count.ToString();
            dataSetCourse11.Tables["Course"].Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            windowUpdate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainWindow_Load(this, new EventArgs());
        }

        private ArrayList courseSelectedList = new ArrayList();
        private ArrayList courseRemovedList = new ArrayList();
        private ArrayList courseOriginList = new ArrayList();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // 选课
                foreach (String course_id in courseSelectedList)
                {
                    if (courseOriginList.Contains(course_id))
                        continue;
                    /***
                    //MessageBox.Show("1");
                    DataRow newRow = dataSetCourseChanged11.Tables["Student_Course"].NewRow();
                    //MessageBox.Show("2");
                    newRow["course_id"] = course_id;
                    newRow["student_id"] = studentID;
                    //MessageBox.Show("3");
                    // problem is here
                    dataSetCourseChanged11.Tables["Student_Course"].Rows.InsertAt(newRow, 0);
                    //MessageBox.Show("选");
                    ***/
                    String sqlInsert = "INSERT INTO Student_Course (student_id, course_id) VALUES (?, ?)";
                    OleDbCommand cmdInsert = new OleDbCommand(sqlInsert);
                    cmdInsert.Connection = oleDbConnection1;

                    cmdInsert.Parameters.Add("@p1", OleDbType.VarChar, 10).Value = studentID;
                    cmdInsert.Parameters.Add("@p2", OleDbType.VarChar, 5).Value = course_id;
                    oleDbConnection1.Open();
                    cmdInsert.ExecuteNonQuery();
                    oleDbConnection1.Close();

                }
                oleDbDataAdapter3.Update(dataSetCourseChanged11, "Student_Course");

                // 退课
                foreach (String course_id in courseRemovedList)
                {
                    String sqlDelete = "DELETE FROM Student_Course WHERE student_id = '" + studentID + "' AND course_id = '" + course_id + "'";
                    oleDbDataAdapter3.DeleteCommand.CommandText = sqlDelete;
                    oleDbDataAdapter3.DeleteCommand.Connection.Open();
                    oleDbDataAdapter3.DeleteCommand.ExecuteNonQuery();
                    oleDbDataAdapter3.DeleteCommand.Connection.Close();
                    //MessageBox.Show("退");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("选课失败!\n原因:" + exception.Message);
                return;
            }
            MessageBox.Show("选课成功!");
            courseRemovedList.Clear();
            courseSelectedList.Clear();
            MainWindow_Load(this, new EventArgs());
        }
    }
}