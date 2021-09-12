
namespace CourseManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbWindow = new System.Windows.Forms.GroupBox();
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.SuspendLayout();
            // 
            // gpbWindow
            // 
            this.gpbWindow.BackColor = System.Drawing.Color.YellowGreen;
            this.gpbWindow.Location = new System.Drawing.Point(481, 12);
            this.gpbWindow.Name = "gpbWindow";
            this.gpbWindow.Size = new System.Drawing.Size(1578, 1079);
            this.gpbWindow.TabIndex = 0;
            this.gpbWindow.TabStop = false;
            this.gpbWindow.Text = "groupBox1";
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.Location = new System.Drawing.Point(161, 141);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Size = new System.Drawing.Size(132, 72);
            this.btnStudentCourse.TabIndex = 1;
            this.btnStudentCourse.Text = "button1";
            this.btnStudentCourse.UseVisualStyleBackColor = true;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT id, name, credit, [time], teacher_id\r\nFROM   Course";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [CourseManagementSystem].[dbo].[Course] ([id], [name], [credit], [tim" +
    "e], [teacher_id]) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Char, 0, "id"),
            new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarChar, 0, "name"),
            new System.Data.OleDb.OleDbParameter("credit", System.Data.OleDb.OleDbType.Integer, 0, "credit"),
            new System.Data.OleDb.OleDbParameter("time", System.Data.OleDb.OleDbType.VarChar, 0, "time"),
            new System.Data.OleDb.OleDbParameter("teacher_id", System.Data.OleDb.OleDbType.Char, 0, "teacher_id")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("id", System.Data.OleDb.OleDbType.Char, 0, "id"),
            new System.Data.OleDb.OleDbParameter("name", System.Data.OleDb.OleDbType.VarChar, 0, "name"),
            new System.Data.OleDb.OleDbParameter("credit", System.Data.OleDb.OleDbType.Integer, 0, "credit"),
            new System.Data.OleDb.OleDbParameter("time", System.Data.OleDb.OleDbType.VarChar, 0, "time"),
            new System.Data.OleDb.OleDbParameter("teacher_id", System.Data.OleDb.OleDbType.Char, 0, "teacher_id"),
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_name", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_time", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_teacher_id", System.Data.OleDb.OleDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "teacher_id", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [CourseManagementSystem].[dbo].[Course] WHERE (([id] = ?) AND ([name]" +
    " = ?) AND ((? = 1 AND [credit] IS NULL) OR ([credit] = ?)) AND ([time] = ?) AND " +
    "([teacher_id] = ?))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_id", System.Data.OleDb.OleDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_name", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_time", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_teacher_id", System.Data.OleDb.OleDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "teacher_id", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Course", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("credit", "credit"),
                        new System.Data.Common.DataColumnMapping("time", "time"),
                        new System.Data.Common.DataColumnMapping("teacher_id", "teacher_id")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-KNJPVQ35\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=CourseManagementSystem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 1182);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStudentCourse);
            this.Controls.Add(this.gpbWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbWindow;
        private System.Windows.Forms.Button btnStudentCourse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}

