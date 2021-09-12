
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
            this.gpbWindow = new System.Windows.Forms.GroupBox();
            this.btnStudentCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpbWindow
            // 
            this.gpbWindow.Location = new System.Drawing.Point(227, 27);
            this.gpbWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbWindow.Name = "gpbWindow";
            this.gpbWindow.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbWindow.Size = new System.Drawing.Size(843, 633);
            this.gpbWindow.TabIndex = 0;
            this.gpbWindow.TabStop = false;
            // 
            // btnStudentCourse
            // 
            this.btnStudentCourse.Location = new System.Drawing.Point(67, 42);
            this.btnStudentCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudentCourse.Name = "btnStudentCourse";
            this.btnStudentCourse.Size = new System.Drawing.Size(56, 28);
            this.btnStudentCourse.TabIndex = 1;
            this.btnStudentCourse.Text = "button1";
            this.btnStudentCourse.UseVisualStyleBackColor = true;
            this.btnStudentCourse.Click += new System.EventHandler(this.btnStudentCourse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 218);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 686);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStudentCourse);
            this.Controls.Add(this.gpbWindow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button4;
    }
}

