﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Components;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace SmartLearn
{
    public partial class Test : MetroForm
    {
        List<string[]> questionsAnswers = new List<string[]>();
        int currentQuestion = 0;

        public Test()
        {
            InitializeComponent();
        }

        private void Run_Load(object sender, EventArgs e)
        {
            ViewerAnswers.StyleManager = this.StyleManager;
            ViewerQuestions.StyleManager = this.StyleManager;
            ShowAnswer.StyleManager = this.StyleManager;
            ShowNext.StyleManager = this.StyleManager;
            OpenFile.StyleManager = this.StyleManager;
            SaveFile.StyleManager = this.StyleManager;
            ViewerAnswers.Visible = false;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (ViewerAnswers.Visible)
                ViewerAnswers.Visible = false;
            else
                ViewerAnswers.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ViewerAnswers.Visible = false;

            if ((currentQuestion > questionsAnswers.Count)||(currentQuestion == questionsAnswers.Count))
            {
                currentQuestion = 0;
            }
            else
            {
                currentQuestion++;
                if ((currentQuestion > questionsAnswers.Count) || (currentQuestion == questionsAnswers.Count))
                {
                    currentQuestion = 0;
                }
            }
            ViewerQuestions.Text = questionsAnswers[currentQuestion][0] + "\r\n";
            ViewerAnswers.Text = questionsAnswers[currentQuestion][1] + "\r\n";


        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "thequestions.txt"; ;
            if (OpenCards.ShowDialog() == DialogResult.OK)
            {
                path = OpenCards.FileName;
                ShowNext.Enabled = true;
                ShowAnswer.Enabled = true;
                using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("windows-1251")))//System.IO.File.ReadAllText(fileName путь к файлу )
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] questionAnswer = line.Split(';');
                        questionsAnswers.Add(questionAnswer);
                    }
                }
                ViewerQuestions.Text += questionsAnswers[0][0] + "\r\n";
                ViewerAnswers.Text += questionsAnswers[0][1] + "\r\n";
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string path; ;
            if (SaveCards.ShowDialog() == DialogResult.OK)
            {
                path = SaveCards.FileName;
                string buff ="";
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < questionsAnswers.Count; i++)
                    {
                        buff += questionsAnswers[i][0];
                        buff += " — ";
                        buff += questionsAnswers[i][1];
                        writer.WriteLine(buff);
                        buff = "";
                    }
                }

                
            }
        }

        private void ViewerAnswers_Click(object sender, EventArgs e)
        {

        }
    }
}
