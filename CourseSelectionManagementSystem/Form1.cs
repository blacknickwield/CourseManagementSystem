using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelectionManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String conditionStatement = " WHERE id = '" + tbxID.Text + "' AND passwd = '" + tbxPassword.Text + "'";
            String originSelectCommand = oleDbDataAdapter1.SelectCommand.CommandText;
            oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand + conditionStatement;
            try
            {
                oleDbDataAdapter1.Fill(dataSetStudentInfo11);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
                return;
            }

            if (dataSetStudentInfo11.Tables["Student"].Rows.Count <= 0)
            {
                MessageBox.Show("请检查学号和密码");
                oleDbDataAdapter1.SelectCommand.CommandText = originSelectCommand;
                return;
            }
            MessageBox.Show("登录成功");
            studentID = dataSetStudentInfo11.Tables["Student"].Rows[0]["id"].ToString();
            password = dataSetStudentInfo11.Tables["Student"].Rows[0]["passwd"].ToString();
            name = dataSetStudentInfo11.Tables["Student"].Rows[0]["name"].ToString();
            DialogResult = DialogResult.OK;
            Dispose();
            Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private String studentID = null;
        private String name = null;
        private String password = null;
        
        public String StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
