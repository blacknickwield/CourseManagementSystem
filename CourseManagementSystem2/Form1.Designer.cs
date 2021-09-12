
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
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gpbWindow = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.Location = new System.Drawing.Point(103, 109);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Size = new System.Drawing.Size(167, 84);
            this.btnStudentCourse.TabIndex = 0;
            this.btnStudentCourse.Text = "学生课程管理";
            this.btnStudentCourse.UseVisualStyleBackColor = true;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // gpbWindow
            // 
            this.gpbWindow.BackColor = System.Drawing.Color.YellowGreen;
            this.gpbWindow.Location = new System.Drawing.Point(403, 37);
            this.gpbWindow.Name = "gpbWindow";
            this.gpbWindow.Size = new System.Drawing.Size(1601, 1096);
            this.gpbWindow.TabIndex = 3;
            this.gpbWindow.TabStop = false;
            this.gpbWindow.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2037, 1156);
            this.Controls.Add(this.gpbWindow);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStudentCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentCourse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gpbWindow;
    }
}

