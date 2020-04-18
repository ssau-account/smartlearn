﻿using MetroFramework.Forms;
using MetroFramework.Components;
namespace SmartLearn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartLearn));
            this.Test = new MetroFramework.Controls.MetroButton();
            this.MainStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CheckTheme = new MetroFramework.Controls.MetroCheckBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LearningButton = new MetroFramework.Controls.MetroButton();
            this.ButtonHelp = new MetroFramework.Controls.MetroLink();
            this.MyDecks = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Test.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Test.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Test.Location = new System.Drawing.Point(203, 329);
            this.Test.Margin = new System.Windows.Forms.Padding(4);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(173, 59);
            this.Test.TabIndex = 3;
            this.Test.TabStop = false;
            this.Test.Text = "Тест";
            this.Test.UseSelectable = true;
            this.Test.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainStyle
            // 
            this.MainStyle.Owner = this;
            // 
            // CheckTheme
            // 
            this.CheckTheme.AutoSize = true;
            this.CheckTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckTheme.Location = new System.Drawing.Point(425, 487);
            this.CheckTheme.Margin = new System.Windows.Forms.Padding(4);
            this.CheckTheme.Name = "CheckTheme";
            this.CheckTheme.Size = new System.Drawing.Size(100, 17);
            this.CheckTheme.TabIndex = 7;
            this.CheckTheme.Text = "Тёмная тема";
            this.CheckTheme.UseSelectable = true;
            this.CheckTheme.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Enabled = false;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(203, 21);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(43, 39);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // LearningButton
            // 
            this.LearningButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LearningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LearningButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LearningButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.LearningButton.Location = new System.Drawing.Point(203, 155);
            this.LearningButton.Margin = new System.Windows.Forms.Padding(4);
            this.LearningButton.Name = "LearningButton";
            this.LearningButton.Size = new System.Drawing.Size(173, 59);
            this.LearningButton.TabIndex = 10;
            this.LearningButton.TabStop = false;
            this.LearningButton.Text = "Учить";
            this.LearningButton.UseSelectable = true;
            this.LearningButton.Click += new System.EventHandler(this.LearningButton_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp.Location = new System.Drawing.Point(23, 481);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(146, 23);
            this.ButtonHelp.TabIndex = 11;
            this.ButtonHelp.Text = "О программе";
            this.ButtonHelp.UseSelectable = true;
            this.ButtonHelp.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // MyDecks
            // 
            this.MyDecks.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.MyDecks.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.MyDecks.Location = new System.Drawing.Point(203, 242);
            this.MyDecks.Name = "MyDecks";
            this.MyDecks.Size = new System.Drawing.Size(173, 59);
            this.MyDecks.TabIndex = 12;
            this.MyDecks.TabStop = false;
            this.MyDecks.Text = "Мои колоды";
            this.MyDecks.UseSelectable = true;
            // 
            // SmartLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 529);
            this.Controls.Add(this.MyDecks);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.LearningButton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CheckTheme);
            this.Controls.Add(this.Test);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 529);
            this.MinimumSize = new System.Drawing.Size(573, 529);
            this.Name = "SmartLearn";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "SmartLearn";
            this.Load += new System.EventHandler(this.SmartLearn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton Test;
        public MetroStyleManager MainStyle;
        private MetroFramework.Controls.MetroCheckBox CheckTheme;
        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroButton LearningButton;
        private MetroFramework.Controls.MetroLink ButtonHelp;
        private MetroFramework.Controls.MetroButton MyDecks;
    }
}

