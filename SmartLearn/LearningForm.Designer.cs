﻿namespace SmartLearn
{
    partial class LearningForm
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
            this.LeShowAnswer = new MetroFramework.Controls.MetroButton();
            this.LeNextQuestion = new MetroFramework.Controls.MetroButton();
            this.LePrevQuestion = new MetroFramework.Controls.MetroButton();
            this.LeOpenCards = new MetroFramework.Controls.MetroButton();
            this.LeViewer = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // LeShowAnswer
            // 
            this.LeShowAnswer.Location = new System.Drawing.Point(344, 484);
            this.LeShowAnswer.Name = "LeShowAnswer";
            this.LeShowAnswer.Size = new System.Drawing.Size(148, 44);
            this.LeShowAnswer.TabIndex = 1;
            this.LeShowAnswer.Text = "Показать ответ";
            this.LeShowAnswer.UseSelectable = true;
            // 
            // LeNextQuestion
            // 
            this.LeNextQuestion.Location = new System.Drawing.Point(522, 484);
            this.LeNextQuestion.Name = "LeNextQuestion";
            this.LeNextQuestion.Size = new System.Drawing.Size(148, 44);
            this.LeNextQuestion.TabIndex = 3;
            this.LeNextQuestion.Text = "Следующий вопрос";
            this.LeNextQuestion.UseSelectable = true;
            // 
            // LePrevQuestion
            // 
            this.LePrevQuestion.Location = new System.Drawing.Point(166, 484);
            this.LePrevQuestion.Name = "LePrevQuestion";
            this.LePrevQuestion.Size = new System.Drawing.Size(148, 44);
            this.LePrevQuestion.TabIndex = 4;
            this.LePrevQuestion.Text = "Предыдущий вопрос";
            this.LePrevQuestion.UseSelectable = true;
            // 
            // LeOpenCards
            // 
            this.LeOpenCards.Location = new System.Drawing.Point(344, 13);
            this.LeOpenCards.Name = "LeOpenCards";
            this.LeOpenCards.Size = new System.Drawing.Size(148, 44);
            this.LeOpenCards.TabIndex = 0;
            this.LeOpenCards.Text = "Открыть колоду";
            this.LeOpenCards.UseSelectable = true;
            // 
            // LeViewer
            // 
            // 
            // 
            // 
            this.LeViewer.CustomButton.Image = null;
            this.LeViewer.CustomButton.Location = new System.Drawing.Point(400, 1);
            this.LeViewer.CustomButton.Name = "";
            this.LeViewer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LeViewer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LeViewer.CustomButton.TabIndex = 1;
            this.LeViewer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LeViewer.CustomButton.UseSelectable = true;
            this.LeViewer.CustomButton.Visible = false;
            this.LeViewer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LeViewer.Lines = new string[0];
            this.LeViewer.Location = new System.Drawing.Point(166, 63);
            this.LeViewer.MaxLength = 32767;
            this.LeViewer.Name = "LeViewer";
            this.LeViewer.PasswordChar = '\0';
            this.LeViewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LeViewer.SelectedText = "";
            this.LeViewer.SelectionLength = 0;
            this.LeViewer.SelectionStart = 0;
            this.LeViewer.ShortcutsEnabled = true;
            this.LeViewer.Size = new System.Drawing.Size(504, 400);
            this.LeViewer.TabIndex = 5;
            this.LeViewer.UseSelectable = true;
            this.LeViewer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LeViewer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 582);
            this.Controls.Add(this.LeViewer);
            this.Controls.Add(this.LePrevQuestion);
            this.Controls.Add(this.LeNextQuestion);
            this.Controls.Add(this.LeShowAnswer);
            this.Controls.Add(this.LeOpenCards);
            this.Name = "LearningForm";
            this.Text = "Обучение";
            this.Load += new System.EventHandler(this.LearningForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton LeShowAnswer;
        private MetroFramework.Controls.MetroButton LeNextQuestion;
        private MetroFramework.Controls.MetroButton LePrevQuestion;
        private MetroFramework.Controls.MetroButton LeOpenCards;
        private MetroFramework.Controls.MetroTextBox LeViewer;
    }
}