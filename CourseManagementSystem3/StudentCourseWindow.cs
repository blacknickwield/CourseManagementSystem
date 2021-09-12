using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            
            /***
            string connStr = "Server=.;Database=CourseManagementSystem;Integrated Security=SSPI";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connStr);
                //打开数据库
                conn.Open();
                string sql = "select * from Course";
                //创建SqlDataAdapter类的对象
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //创建DataSet类的对象
                DataSet ds = new DataSet();
                //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                sda.Fill(ds);
                //设置表格控件的DataSource属性
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误！" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
            ***/
        }
    }
}
