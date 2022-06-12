namespace lab5work
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
            this.LBCourseCode = new System.Windows.Forms.Label();
            this.LBSemester = new System.Windows.Forms.Label();
            this.LBProfessor = new System.Windows.Forms.Label();
            this.TBCourseCode = new System.Windows.Forms.TextBox();
            this.TBSemester = new System.Windows.Forms.TextBox();
            this.TBProfessor = new System.Windows.Forms.TextBox();
            this.BTStartSurvey = new System.Windows.Forms.Button();
            this.BTExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBCourseCode
            // 
            this.LBCourseCode.AutoSize = true;
            this.LBCourseCode.Location = new System.Drawing.Point(59, 45);
            this.LBCourseCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBCourseCode.Name = "LBCourseCode";
            this.LBCourseCode.Size = new System.Drawing.Size(29, 12);
            this.LBCourseCode.TabIndex = 0;
            this.LBCourseCode.Text = "학번";
            // 
            // LBSemester
            // 
            this.LBSemester.AutoSize = true;
            this.LBSemester.Location = new System.Drawing.Point(59, 78);
            this.LBSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBSemester.Name = "LBSemester";
            this.LBSemester.Size = new System.Drawing.Size(29, 12);
            this.LBSemester.TabIndex = 1;
            this.LBSemester.Text = "성명";
            // 
            // LBProfessor
            // 
            this.LBProfessor.AutoSize = true;
            this.LBProfessor.Location = new System.Drawing.Point(59, 113);
            this.LBProfessor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBProfessor.Name = "LBProfessor";
            this.LBProfessor.Size = new System.Drawing.Size(59, 12);
            this.LBProfessor.TabIndex = 2;
            this.LBProfessor.Text = "Professor";
            // 
            // TBCourseCode
            // 
            this.TBCourseCode.Location = new System.Drawing.Point(195, 42);
            this.TBCourseCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBCourseCode.Name = "TBCourseCode";
            this.TBCourseCode.Size = new System.Drawing.Size(116, 21);
            this.TBCourseCode.TabIndex = 3;
            // 
            // TBSemester
            // 
            this.TBSemester.Location = new System.Drawing.Point(195, 76);
            this.TBSemester.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBSemester.Name = "TBSemester";
            this.TBSemester.Size = new System.Drawing.Size(116, 21);
            this.TBSemester.TabIndex = 4;
            // 
            // TBProfessor
            // 
            this.TBProfessor.Location = new System.Drawing.Point(195, 110);
            this.TBProfessor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBProfessor.Name = "TBProfessor";
            this.TBProfessor.Size = new System.Drawing.Size(116, 21);
            this.TBProfessor.TabIndex = 5;
            // 
            // BTStartSurvey
            // 
            this.BTStartSurvey.Location = new System.Drawing.Point(140, 170);
            this.BTStartSurvey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTStartSurvey.Name = "BTStartSurvey";
            this.BTStartSurvey.Size = new System.Drawing.Size(88, 21);
            this.BTStartSurvey.TabIndex = 6;
            this.BTStartSurvey.Text = "Start Survey";
            this.BTStartSurvey.UseVisualStyleBackColor = true;
            this.BTStartSurvey.Click += new System.EventHandler(this.BTStartSurvey_Click);
            // 
            // BTExit
            // 
            this.BTExit.Location = new System.Drawing.Point(140, 208);
            this.BTExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(88, 21);
            this.BTExit.TabIndex = 7;
            this.BTExit.Text = "Exit";
            this.BTExit.UseVisualStyleBackColor = true;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.BTExit);
            this.Controls.Add(this.BTStartSurvey);
            this.Controls.Add(this.TBProfessor);
            this.Controls.Add(this.TBSemester);
            this.Controls.Add(this.TBCourseCode);
            this.Controls.Add(this.LBProfessor);
            this.Controls.Add(this.LBSemester);
            this.Controls.Add(this.LBCourseCode);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Student Survey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBCourseCode;
        private System.Windows.Forms.Label LBSemester;
        private System.Windows.Forms.Label LBProfessor;
        private System.Windows.Forms.TextBox TBCourseCode;
        private System.Windows.Forms.TextBox TBSemester;
        private System.Windows.Forms.TextBox TBProfessor;
        private System.Windows.Forms.Button BTStartSurvey;
        private System.Windows.Forms.Button BTExit;
    }
}

