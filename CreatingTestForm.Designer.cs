namespace TestingSystem
{
    partial class CreatingTestForm
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
            this.lblTestsName = new System.Windows.Forms.Label();
            this.textBoxTestsName = new System.Windows.Forms.TextBox();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.buttonDeleteQuestion = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.textBoxQuestionTask = new System.Windows.Forms.TextBox();
            this.lblQuestionName = new System.Windows.Forms.Label();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.textBoxAnswerText = new System.Windows.Forms.TextBox();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.checkBoxRightAnswer = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTestsName
            // 
            this.lblTestsName.AutoSize = true;
            this.lblTestsName.Location = new System.Drawing.Point(12, 9);
            this.lblTestsName.Name = "lblTestsName";
            this.lblTestsName.Size = new System.Drawing.Size(88, 13);
            this.lblTestsName.TabIndex = 0;
            this.lblTestsName.Text = "Название теста";
            // 
            // textBoxTestsName
            // 
            this.textBoxTestsName.Location = new System.Drawing.Point(15, 25);
            this.textBoxTestsName.Name = "textBoxTestsName";
            this.textBoxTestsName.Size = new System.Drawing.Size(267, 20);
            this.textBoxTestsName.TabIndex = 1;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.Location = new System.Drawing.Point(15, 72);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(143, 342);
            this.listBoxQuestions.TabIndex = 2;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.ListBoxQuestions_SelectedIndexChanged);
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Location = new System.Drawing.Point(15, 57);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(95, 13);
            this.lblQuestions.TabIndex = 3;
            this.lblQuestions.Text = "Список вопросов";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(164, 149);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(118, 23);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.BtnAddQuestion_Click);
            // 
            // buttonDeleteQuestion
            // 
            this.buttonDeleteQuestion.Location = new System.Drawing.Point(164, 178);
            this.buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            this.buttonDeleteQuestion.Size = new System.Drawing.Size(118, 23);
            this.buttonDeleteQuestion.TabIndex = 5;
            this.buttonDeleteQuestion.Text = "Удалить вопрос";
            this.buttonDeleteQuestion.UseVisualStyleBackColor = true;
            this.buttonDeleteQuestion.Click += new System.EventHandler(this.ButtonDeleteQuestion_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(299, 57);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(87, 13);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "Список ответов";
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.Location = new System.Drawing.Point(299, 72);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(143, 342);
            this.listBoxAnswers.TabIndex = 6;
            this.listBoxAnswers.SelectedIndexChanged += new System.EventHandler(this.ListBoxAnswers_SelectedIndexChanged);
            // 
            // textBoxQuestionTask
            // 
            this.textBoxQuestionTask.Location = new System.Drawing.Point(164, 73);
            this.textBoxQuestionTask.Name = "textBoxQuestionTask";
            this.textBoxQuestionTask.Size = new System.Drawing.Size(118, 20);
            this.textBoxQuestionTask.TabIndex = 10;
            this.textBoxQuestionTask.Leave += new System.EventHandler(this.TextBoxQuestionTask_Leave);
            // 
            // lblQuestionName
            // 
            this.lblQuestionName.AutoSize = true;
            this.lblQuestionName.Location = new System.Drawing.Point(164, 57);
            this.lblQuestionName.Name = "lblQuestionName";
            this.lblQuestionName.Size = new System.Drawing.Size(82, 13);
            this.lblQuestionName.TabIndex = 11;
            this.lblQuestionName.Text = "Текст вопроса";
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Location = new System.Drawing.Point(451, 57);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(74, 13);
            this.lblAnswerText.TabIndex = 15;
            this.lblAnswerText.Text = "Текст ответа";
            // 
            // textBoxAnswerText
            // 
            this.textBoxAnswerText.Location = new System.Drawing.Point(451, 73);
            this.textBoxAnswerText.Name = "textBoxAnswerText";
            this.textBoxAnswerText.Size = new System.Drawing.Size(118, 20);
            this.textBoxAnswerText.TabIndex = 14;
            this.textBoxAnswerText.Leave += new System.EventHandler(this.TextBoxAnswerText_Leave);
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Location = new System.Drawing.Point(451, 126);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteAnswer.TabIndex = 13;
            this.btnDeleteAnswer.Text = "Удалить ответ";
            this.btnDeleteAnswer.UseVisualStyleBackColor = true;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.BtnDeleteAnswer_Click);
            this.btnDeleteAnswer.Leave += new System.EventHandler(this.TextBoxAnswerText_Leave);
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(451, 97);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(118, 23);
            this.btnAddAnswer.TabIndex = 12;
            this.btnAddAnswer.Text = "Добавить ответ";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.BtnAddAnswer_Click);
            this.btnAddAnswer.Leave += new System.EventHandler(this.TextBoxAnswerText_Leave);
            // 
            // checkBoxRightAnswer
            // 
            this.checkBoxRightAnswer.AutoSize = true;
            this.checkBoxRightAnswer.Location = new System.Drawing.Point(454, 155);
            this.checkBoxRightAnswer.Name = "checkBoxRightAnswer";
            this.checkBoxRightAnswer.Size = new System.Drawing.Size(96, 17);
            this.checkBoxRightAnswer.TabIndex = 16;
            this.checkBoxRightAnswer.Text = "Верный ответ";
            this.checkBoxRightAnswer.UseVisualStyleBackColor = true;
            this.checkBoxRightAnswer.Leave += new System.EventHandler(this.TextBoxAnswerText_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 21);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(164, 102);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(77, 13);
            this.lblScore.TabIndex = 19;
            this.lblScore.Text = "Весовой балл";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(164, 118);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(118, 20);
            this.textBoxScore.TabIndex = 18;
            this.textBoxScore.Leave += new System.EventHandler(this.TextBoxScore_Leave);
            // 
            // CreatingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxRightAnswer);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.textBoxAnswerText);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.lblQuestionName);
            this.Controls.Add(this.textBoxQuestionTask);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.listBoxAnswers);
            this.Controls.Add(this.buttonDeleteQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.textBoxTestsName);
            this.Controls.Add(this.lblTestsName);
            this.MaximumSize = new System.Drawing.Size(600, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 469);
            this.Name = "CreatingTestForm";
            this.Text = "Создание теста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatingTestForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestsName;
        private System.Windows.Forms.TextBox textBoxTestsName;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button buttonDeleteQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox listBoxAnswers;
        private System.Windows.Forms.TextBox textBoxQuestionTask;
        private System.Windows.Forms.Label lblQuestionName;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.TextBox textBoxAnswerText;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.CheckBox checkBoxRightAnswer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox textBoxScore;
    }
}