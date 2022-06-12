namespace lab5work
{
    partial class FormQ3
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
            this.BTNext3 = new System.Windows.Forms.Button();
            this.labelQ3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBoxQ3 = new System.Windows.Forms.GroupBox();
            this.RBNA = new System.Windows.Forms.RadioButton();
            this.RBAlways = new System.Windows.Forms.RadioButton();
            this.RBMostTime = new System.Windows.Forms.RadioButton();
            this.RBSomeTime = new System.Windows.Forms.RadioButton();
            this.RBNever = new System.Windows.Forms.RadioButton();
            this.LBQ3 = new System.Windows.Forms.Label();
            this.groupBoxQ3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNext3
            // 
            this.BTNext3.Location = new System.Drawing.Point(234, 173);
            this.BTNext3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNext3.Name = "BTNext3";
            this.BTNext3.Size = new System.Drawing.Size(92, 27);
            this.BTNext3.TabIndex = 14;
            this.BTNext3.Text = "Next";
            this.BTNext3.UseVisualStyleBackColor = true;
            this.BTNext3.Click += new System.EventHandler(this.BTNext3_Click);
            // 
            // labelQ3
            // 
            this.labelQ3.AutoSize = true;
            this.labelQ3.Location = new System.Drawing.Point(209, 69);
            this.labelQ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ3.Name = "labelQ3";
            this.labelQ3.Size = new System.Drawing.Size(89, 12);
            this.labelQ3.TabIndex = 13;
            this.labelQ3.Text = "Question 3 of 3";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(212, 96);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar3.Maximum = 3;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(133, 20);
            this.progressBar3.TabIndex = 12;
            this.progressBar3.Value = 3;
            // 
            // groupBoxQ3
            // 
            this.groupBoxQ3.Controls.Add(this.RBNA);
            this.groupBoxQ3.Controls.Add(this.RBAlways);
            this.groupBoxQ3.Controls.Add(this.RBMostTime);
            this.groupBoxQ3.Controls.Add(this.RBSomeTime);
            this.groupBoxQ3.Controls.Add(this.RBNever);
            this.groupBoxQ3.Location = new System.Drawing.Point(24, 60);
            this.groupBoxQ3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ3.Name = "groupBoxQ3";
            this.groupBoxQ3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ3.Size = new System.Drawing.Size(144, 162);
            this.groupBoxQ3.TabIndex = 11;
            this.groupBoxQ3.TabStop = false;
            this.groupBoxQ3.Text = "Answer";
            // 
            // RBNA
            // 
            this.RBNA.AutoSize = true;
            this.RBNA.Location = new System.Drawing.Point(8, 113);
            this.RBNA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBNA.Name = "RBNA";
            this.RBNA.Size = new System.Drawing.Size(105, 16);
            this.RBNA.TabIndex = 4;
            this.RBNA.TabStop = true;
            this.RBNA.Text = "Not Applicable";
            this.RBNA.UseVisualStyleBackColor = true;
            // 
            // RBAlways
            // 
            this.RBAlways.AutoSize = true;
            this.RBAlways.Location = new System.Drawing.Point(8, 91);
            this.RBAlways.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBAlways.Name = "RBAlways";
            this.RBAlways.Size = new System.Drawing.Size(65, 16);
            this.RBAlways.TabIndex = 3;
            this.RBAlways.TabStop = true;
            this.RBAlways.Text = "Always";
            this.RBAlways.UseVisualStyleBackColor = true;
            // 
            // RBMostTime
            // 
            this.RBMostTime.AutoSize = true;
            this.RBMostTime.Location = new System.Drawing.Point(8, 70);
            this.RBMostTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBMostTime.Name = "RBMostTime";
            this.RBMostTime.Size = new System.Drawing.Size(114, 16);
            this.RBMostTime.TabIndex = 2;
            this.RBMostTime.TabStop = true;
            this.RBMostTime.Text = "Most of the time";
            this.RBMostTime.UseVisualStyleBackColor = true;
            // 
            // RBSomeTime
            // 
            this.RBSomeTime.AutoSize = true;
            this.RBSomeTime.Location = new System.Drawing.Point(8, 49);
            this.RBSomeTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBSomeTime.Name = "RBSomeTime";
            this.RBSomeTime.Size = new System.Drawing.Size(119, 16);
            this.RBSomeTime.TabIndex = 1;
            this.RBSomeTime.TabStop = true;
            this.RBSomeTime.Text = "Some of the time";
            this.RBSomeTime.UseVisualStyleBackColor = true;
            // 
            // RBNever
            // 
            this.RBNever.AutoSize = true;
            this.RBNever.Location = new System.Drawing.Point(8, 28);
            this.RBNever.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBNever.Name = "RBNever";
            this.RBNever.Size = new System.Drawing.Size(56, 16);
            this.RBNever.TabIndex = 0;
            this.RBNever.TabStop = true;
            this.RBNever.Text = "Never";
            this.RBNever.UseVisualStyleBackColor = true;
            // 
            // LBQ3
            // 
            this.LBQ3.AutoSize = true;
            this.LBQ3.Location = new System.Drawing.Point(21, 26);
            this.LBQ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBQ3.Name = "LBQ3";
            this.LBQ3.Size = new System.Drawing.Size(213, 12);
            this.LBQ3.TabIndex = 10;
            this.LBQ3.Text = "강의 내용에 대한 만족도는 어떠셨나요";
            // 
            // FormQ3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.BTNext3);
            this.Controls.Add(this.labelQ3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.groupBoxQ3);
            this.Controls.Add(this.LBQ3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormQ3";
            this.Text = "Q3";
            this.groupBoxQ3.ResumeLayout(false);
            this.groupBoxQ3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNext3;
        private System.Windows.Forms.Label labelQ3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox groupBoxQ3;
        private System.Windows.Forms.RadioButton RBNA;
        private System.Windows.Forms.RadioButton RBAlways;
        private System.Windows.Forms.RadioButton RBMostTime;
        private System.Windows.Forms.RadioButton RBSomeTime;
        private System.Windows.Forms.RadioButton RBNever;
        private System.Windows.Forms.Label LBQ3;
    }
}