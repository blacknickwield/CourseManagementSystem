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
using System.Data.SqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.oleDbDataAdapter1.Fill(dataSet11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "SELECT * FROM Course WHERE id = '" + textBox1.Text + "'";
            OleDbCommand cmd = new OleDbCommand(str);
            cmd.Connection = this.oleDbConnection1;
            this.oleDbConnection1.Open();
            cmd.ExecuteNonQuery();
            this.oleDbConnection1.Close();
            this.dataSet11.Clear();
            this.oleDbDataAdapter1.Fill(dataSet11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //String str = "INSERT INTO Course (id, name, credit, time, teacher_id, classroom_id) VALUES(?, ?, ?, ?, ?, ?)";
            //MessageBox.Show(oleDbDataAdapter1.SelectCommand.CommandText);
            oleDbDataAdapter1.SelectCommand.CommandText = "SELECT id, name, credit, time, teacher_id, classroom_id FROM Course WHERE id = '000000000'";
            //MessageBox.Show(oleDbDataAdapter1.SelectCommand.CommandText);
            oleDbDataAdapter1.Update(dataSet11);
            dataSet11.Clear();
            oleDbDataAdapter1.Fill(dataSet11);

        }
    }
}
