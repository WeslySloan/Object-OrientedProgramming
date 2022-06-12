namespace lab5work
{
    partial class FormQ1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LBQ1 = new System.Windows.Forms.Label();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.RBNoOpinion = new System.Windows.Forms.RadioButton();
            this.RBExcellent = new System.Windows.Forms.RadioButton();
            this.RBVGood = new System.Windows.Forms.RadioButton();
            this.RBGood = new System.Windows.Forms.RadioButton();
            this.RBFair = new System.Windows.Forms.RadioButton();
            this.RBPoor = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelQ1 = new System.Windows.Forms.Label();
            this.BTNext1 = new System.Windows.Forms.Button();
            this.groupBoxQ1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBQ1
            // 
            this.LBQ1.AutoSize = true;
            this.LBQ1.Location = new System.Drawing.Point(27, 25);
            this.LBQ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBQ1.Name = "LBQ1";
            this.LBQ1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBQ1.Size = new System.Drawing.Size(209, 12);
            this.LBQ1.TabIndex = 0;
            this.LBQ1.Text = "전체적인 강의의 만족도는 어떠셨나요";
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.Controls.Add(this.RBNoOpinion);
            this.groupBoxQ1.Controls.Add(this.RBExcellent);
            this.groupBoxQ1.Controls.Add(this.RBVGood);
            this.groupBoxQ1.Controls.Add(this.RBGood);
            this.groupBoxQ1.Controls.Add(this.RBFair);
            this.groupBoxQ1.Controls.Add(this.RBPoor);
            this.groupBoxQ1.Location = new System.Drawing.Point(30, 58);
            this.groupBoxQ1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxQ1.Size = new System.Drawing.Size(144, 162);
            this.groupBoxQ1.TabIndex = 1;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Answer";
            // 
            // RBNoOpinion
            // 
            this.RBNoOpinion.AutoSize = true;
            this.RBNoOpinion.Location = new System.Drawing.Point(8, 134);
            this.RBNoOpinion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBNoOpinion.Name = "RBNoOpinion";
            this.RBNoOpinion.Size = new System.Drawing.Size(75, 16);
            this.RBNoOpinion.TabIndex = 5;
            this.RBNoOpinion.TabStop = true;
            this.RBNoOpinion.Text = "의견 없음";
            this.RBNoOpinion.UseVisualStyleBackColor = true;
            // 
            // RBExcellent
            // 
            this.RBExcellent.AutoSize = true;
            this.RBExcellent.Location = new System.Drawing.Point(8, 113);
            this.RBExcellent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBExcellent.Name = "RBExcellent";
            this.RBExcellent.Size = new System.Drawing.Size(75, 16);
            this.RBExcellent.TabIndex = 4;
            this.RBExcellent.TabStop = true;
            this.RBExcellent.Text = "매우 나쁨";
            this.RBExcellent.UseVisualStyleBackColor = true;
            // 
            // RBVGood
            // 
            this.RBVGood.AutoSize = true;
            this.RBVGood.Location = new System.Drawing.Point(8, 91);
            this.RBVGood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBVGood.Name = "RBVGood";
            this.RBVGood.Size = new System.Drawing.Size(47, 16);
            this.RBVGood.TabIndex = 3;
            this.RBVGood.TabStop = true;
            this.RBVGood.Text = "나쁨";
            this.RBVGood.UseVisualStyleBackColor = true;
            // 
            // RBGood
            // 
            this.RBGood.AutoSize = true;
            this.RBGood.Location = new System.Drawing.Point(8, 70);
            this.RBGood.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBGood.Name = "RBGood";
            this.RBGood.Size = new System.Drawing.Size(47, 16);
            this.RBGood.TabIndex = 2;
            this.RBGood.TabStop = true;
            this.RBGood.Text = "보통";
            this.RBGood.UseVisualStyleBackColor = true;
            // 
            // RBFair
            // 
            this.RBFair.AutoSize = true;
            this.RBFair.Location = new System.Drawing.Point(8, 49);
            this.RBFair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBFair.Name = "RBFair";
            this.RBFair.Size = new System.Drawing.Size(47, 16);
            this.RBFair.TabIndex = 1;
            this.RBFair.TabStop = true;
            this.RBFair.Text = "좋음";
            this.RBFair.UseVisualStyleBackColor = true;
            // 
            // RBPoor
            // 
            this.RBPoor.AutoSize = true;
            this.RBPoor.Location = new System.Drawing.Point(8, 28);
            this.RBPoor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RBPoor.Name = "RBPoor";
            this.RBPoor.Size = new System.Drawing.Size(75, 16);
            this.RBPoor.TabIndex = 0;
            this.RBPoor.TabStop = true;
            this.RBPoor.Text = "매우 좋음";
            this.RBPoor.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(218, 94);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(133, 20);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Value = 1;
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Location = new System.Drawing.Point(215, 67);
            this.labelQ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(89, 12);
            this.labelQ1.TabIndex = 3;
            this.labelQ1.Text = "Question 1 of 3";
            // 
            // BTNext1
            // 
            this.BTNext1.Location = new System.Drawing.Point(240, 171);
            this.BTNext1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTNext1.Name = "BTNext1";
            this.BTNext1.Size = new System.Drawing.Size(92, 27);
            this.BTNext1.TabIndex = 4;
            this.BTNext1.Text = "다음";
            this.BTNext1.UseVisualStyleBackColor = true;
            this.BTNext1.Click += new System.EventHandler(this.BTNext1_Click);
            // 
            // FormQ1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 281);
            this.Controls.Add(this.BTNext1);
            this.Controls.Add(this.labelQ1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxQ1);
            this.Controls.Add(this.LBQ1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormQ1";
            this.Text = "Q1";
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label LBQ1;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.RadioButton RBNoOpinion;
        private System.Windows.Forms.RadioButton RBExcellent;
        private System.Windows.Forms.RadioButton RBVGood;
        private System.Windows.Forms.RadioButton RBGood;
        private System.Windows.Forms.RadioButton RBFair;
        private System.Windows.Forms.RadioButton RBPoor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.Button BTNext1;
    }
}