﻿namespace SmartLearn
{
    partial class SmartLearn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_deck = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // add_deck
            // 
            this.add_deck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_deck.Location = new System.Drawing.Point(239, 69);
            this.add_deck.Name = "add_deck";
            this.add_deck.Size = new System.Drawing.Size(148, 58);
            this.add_deck.TabIndex = 0;
            this.add_deck.Text = "Добавить колоду";
            this.add_deck.UseVisualStyleBackColor = true;
            this.add_deck.Click += new System.EventHandler(this.add_deck_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(239, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить карточку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_card_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(239, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Список колод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.view_deck_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(239, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SmartLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_deck);
            this.MaximumSize = new System.Drawing.Size(640, 440);
            this.MinimumSize = new System.Drawing.Size(640, 440);
            this.Name = "SmartLearn";
            this.Text = "SmartLearn";
            this.Load += new System.EventHandler(this.SmartLearn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_deck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

