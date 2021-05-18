namespace TestingSystem
{
    partial class PassingModeForm
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
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.lblTestsName = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.lblNameOfTest = new System.Windows.Forms.Label();
            this.lblTestsNameValue = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTests
            // 
            this.listBoxTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(12, 32);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(197, 121);
            this.listBoxTests.TabIndex = 0;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.ListBoxTests_SelectedIndexChanged);
            // 
            // lblTestsName
            // 
            this.lblTestsName.AutoSize = true;
            this.lblTestsName.Location = new System.Drawing.Point(12, 16);
            this.lblTestsName.Name = "lblTestsName";
            this.lblTestsName.Size = new System.Drawing.Size(39, 13);
            this.lblTestsName.TabIndex = 1;
            this.lblTestsName.Text = "Тесты";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(236, 126);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(89, 36);
            this.btnStartTest.TabIndex = 2;
            this.btnStartTest.Text = "Начать прохождение";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.BtnStartTest_Click);
            // 
            // lblNameOfTest
            // 
            this.lblNameOfTest.AutoSize = true;
            this.lblNameOfTest.Location = new System.Drawing.Point(233, 16);
            this.lblNameOfTest.Name = "lblNameOfTest";
            this.lblNameOfTest.Size = new System.Drawing.Size(57, 13);
            this.lblNameOfTest.TabIndex = 3;
            this.lblNameOfTest.Text = "Название";
            // 
            // lblTestsNameValue
            // 
            this.lblTestsNameValue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTestsNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestsNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestsNameValue.Location = new System.Drawing.Point(236, 32);
            this.lblTestsNameValue.Name = "lblTestsNameValue";
            this.lblTestsNameValue.Size = new System.Drawing.Size(179, 54);
            this.lblTestsNameValue.TabIndex = 4;
            this.lblTestsNameValue.Text = "название";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Location = new System.Drawing.Point(233, 97);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(102, 13);
            this.lblBestScore.TabIndex = 5;
            this.lblBestScore.Text = "Лучший результат:";
            // 
            // PassingModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 179);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblTestsNameValue);
            this.Controls.Add(this.lblNameOfTest);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.lblTestsName);
            this.Controls.Add(this.listBoxTests);
            this.MaximumSize = new System.Drawing.Size(444, 600);
            this.MinimumSize = new System.Drawing.Size(444, 218);
            this.Name = "PassingModeForm";
            this.Text = "Режим прохождения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassingModeForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.PassingModeForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.Label lblTestsName;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label lblNameOfTest;
        private System.Windows.Forms.Label lblTestsNameValue;
        private System.Windows.Forms.Label lblBestScore;
    }
}