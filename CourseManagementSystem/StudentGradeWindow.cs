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
    public partial class StudentGradeWindow : UserControl
    {
        public StudentGradeWindow()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /***
            GradeUpdateWindow gradeUpdateWindow = new GradeUpdateWindow();
            gradeUpdateWindow.Show();
            MessageBox.Show("OK");
            ***/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hhh");
        }

        private void StudentGradeWindow_Load(object sender, EventArgs e)
        {
            //oleDbDataAdapter1.Fill(dataGradeSet11);
        }
    }
}
