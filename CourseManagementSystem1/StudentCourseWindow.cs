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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentCourseWindow_Load(object sender, EventArgs e)
        {
            this.oleDbDataAdapter1.Fill(dataSet11);
        }
    }
}
