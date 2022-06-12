namespace lab5work
{
    partial class FormQ2
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
            this.BTNext2 = new System.Windows.Forms.Button();
            this.labelQ2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBoxQ2 = new System.Windows.Forms.GroupBox();
            this.RBNoOpinion2 = new System.Windows.Forms.RadioButton();
            this.RBExcellent2 = new System.Windows.Forms.RadioButton();
            this.RBVGood2 = new System.Windows.Forms.RadioButton();
            this.RBGood2 = new System.Windows.Forms.RadioButton();
            this.RBFair2 = new System.Windows.Forms.RadioButton();
            this.RBPoor2 = new System.Windows.Forms.RadioButton();
            this.LBQ2 = new System.Windows.Forms.Label();
            this.groupBoxQ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNext2
            // 
            this.BTNext2.Location = new System.Drawing.Point(244, 174);
            this.BTNext2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNext2.Name = "BTNext2";
            this.BTNext2.Size = new System.Drawing.Size(92, 27);
            this.BTNext2.TabIndex = 9;
            this.BTNext2.Text = "다음";
            this.BTNext2.UseVisualStyleBackColor = true;
            this.BTNext2.Click += new System.EventHandler(this.BTNext2_Click);
            // 
            // labelQ2
            // 
            this.labelQ2.AutoSize = true;
            this.labelQ2.Location = new System.Drawing.Point(218, 71);
            this.labelQ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ2.Name = "labelQ2";
            this.labelQ2.Size = new System.Drawing.Size(89, 12);
            this.labelQ2.TabIndex = 8;
            this.labelQ2.Text = "Question 2 of 3";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(222, 98);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar2.Maximum = 3;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(133, 20);
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Value = 2;
            // 
            // groupBoxQ2
            // 
            this.groupBoxQ2.Controls.Add(this.RBNoOpinion2);
            this.groupBoxQ2.Controls.Add(this.RBExcellent2);
            this.groupBoxQ2.Controls.Add(this.RBVGood2);
            this.groupBoxQ2.Controls.Add(this.RBGood2);
            this.groupBoxQ2.Controls.Add(this.RBFair2);
            this.groupBoxQ2.Controls.Add(this.RBPoor2);
            this.groupBoxQ2.Location = new System.Drawing.Point(34, 62);
            this.groupBoxQ2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ2.Name = "groupBoxQ2";
            this.groupBoxQ2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ2.Size = new System.Drawing.Size(144, 162);
            this.groupBoxQ2.TabIndex = 6;
            this.groupBoxQ2.TabStop = false;
            this.groupBoxQ2.Text = "Answer";
            // 
            // RBNoOpinion2
            // 
            this.RBNoOpinion2.AutoSize = true;
            this.RBNoOpinion2.Location = new System.Drawing.Point(8, 134);
            this.RBNoOpinion2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBNoOpinion2.Name = "RBNoOpinion2";
            this.RBNoOpinion2.Size = new System.Drawing.Size(75, 16);
            this.RBNoOpinion2.TabIndex = 5;
            this.RBNoOpinion2.TabStop = true;
            this.RBNoOpinion2.Text = "의견 없음";
            this.RBNoOpinion2.UseVisualStyleBackColor = true;
            // 
            // RBExcellent2
            // 
            this.RBExcellent2.AutoSize = true;
            this.RBExcellent2.Location = new System.Drawing.Point(8, 113);
            this.RBExcellent2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBExcellent2.Name = "RBExcellent2";
            this.RBExcellent2.Size = new System.Drawing.Size(75, 16);
            this.RBExcellent2.TabIndex = 4;
            this.RBExcellent2.TabStop = true;
            this.RBExcellent2.Text = "매우 나쁨";
            this.RBExcellent2.UseVisualStyleBackColor = true;
            // 
            // RBVGood2
            // 
            this.RBVGood2.AutoSize = true;
            this.RBVGood2.Location = new System.Drawing.Point(8, 91);
            this.RBVGood2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBVGood2.Name = "RBVGood2";
            this.RBVGood2.Size = new System.Drawing.Size(47, 16);
            this.RBVGood2.TabIndex = 3;
            this.RBVGood2.TabStop = true;
            this.RBVGood2.Text = "나쁨";
            this.RBVGood2.UseVisualStyleBackColor = true;
            // 
            // RBGood2
            // 
            this.RBGood2.AutoSize = true;
            this.RBGood2.Location = new System.Drawing.Point(8, 70);
            this.RBGood2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBGood2.Name = "RBGood2";
            this.RBGood2.Size = new System.Drawing.Size(47, 16);
            this.RBGood2.TabIndex = 2;
            this.RBGood2.TabStop = true;
            this.RBGood2.Text = "보통";
            this.RBGood2.UseVisualStyleBackColor = true;
            // 
            // RBFair2
            // 
            this.RBFair2.AutoSize = true;
            this.RBFair2.Location = new System.Drawing.Point(8, 49);
            this.RBFair2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBFair2.Name = "RBFair2";
            this.RBFair2.Size = new System.Drawing.Size(47, 16);
            this.RBFair2.TabIndex = 1;
            this.RBFair2.TabStop = true;
            this.RBFair2.Text = "좋음";
            this.RBFair2.UseVisualStyleBackColor = true;
            // 
            // RBPoor2
            // 
            this.RBPoor2.AutoSize = true;
            this.RBPoor2.Location = new System.Drawing.Point(8, 28);
            this.RBPoor2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBPoor2.Name = "RBPoor2";
            this.RBPoor2.Size = new System.Drawing.Size(75, 16);
            this.RBPoor2.TabIndex = 0;
            this.RBPoor2.TabStop = true;
            this.RBPoor2.Text = "매우 좋음";
            this.RBPoor2.UseVisualStyleBackColor = true;
            // 
            // LBQ2
            // 
            this.LBQ2.AutoSize = true;
            this.LBQ2.Location = new System.Drawing.Point(30, 29);
            this.LBQ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBQ2.Name = "LBQ2";
            this.LBQ2.Size = new System.Drawing.Size(197, 12);
            this.LBQ2.TabIndex = 5;
            this.LBQ2.Text = "교수님에 대한 만족도는 어떠셨나요";
            // 
            // FormQ2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.BTNext2);
            this.Controls.Add(this.labelQ2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.groupBoxQ2);
            this.Controls.Add(this.LBQ2);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormQ2";
            this.Text = "Q2";
            this.groupBoxQ2.ResumeLayout(false);
            this.groupBoxQ2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNext2;
        private System.Windows.Forms.Label labelQ2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBoxQ2;
        private System.Windows.Forms.RadioButton RBNoOpinion2;
        private System.Windows.Forms.RadioButton RBExcellent2;
        private System.Windows.Forms.RadioButton RBVGood2;
        private System.Windows.Forms.RadioButton RBGood2;
        private System.Windows.Forms.RadioButton RBFair2;
        private System.Windows.Forms.RadioButton RBPoor2;
        private System.Windows.Forms.Label LBQ2;
    }
}