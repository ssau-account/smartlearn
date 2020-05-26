﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Data.SQLite;
using System.Drawing.Printing;

namespace SmartLearn
{
    public partial class MyCardLists : MetroForm
    {
        private SQLiteConnection DB;
        CardList Deck;
        List <string> NameTable;
        DataBase db;
        string result;

        public MyCardLists()
        {
            InitializeComponent();
        }


        private void MyCardLists_Load(object sender, EventArgs e)
        {
            bDeleteCardList.StyleManager = this.StyleManager;
            bEditCardList.StyleManager = this.StyleManager;
            bLearnCardList.StyleManager = this.StyleManager;
            CardListComboBox.StyleManager = this.StyleManager;
            bNewCardList.StyleManager = this.StyleManager;
            NameTable = new List<string>();
            db = new DataBase();
            db.LoadNamesOfCardLists(NameTable);
            for (int i = 0; i < NameTable.Count; i++)
            {
                CardListComboBox.Items.Add(NameTable[i]);
            }
            if (CardListComboBox.Items.Count != 0)
            {
                CardListComboBox.SelectedIndex = 0;
            }
        }

        private void AddCardList_Click(object sender, EventArgs e)
        {
            
        }

        private void CardListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void bImportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bExportCardList_Click(object sender, EventArgs e)
        {

        }

        private void bNewCardList_Click(object sender, EventArgs e)
        {
            CreateCardList createcardlist = new CreateCardList(NameTable);
            createcardlist.StyleManager = this.StyleManager;
            createcardlist.ShowDialog();
            CardListComboBox.Items.Clear(); 
            MyCardLists_Load(sender, e);
        }

        private void bEditCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }

                this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
                db = new DataBase();
                db.LoadCardList(Deck);
                EditCardList editcardlist = new EditCardList(Deck);
                editcardlist.StyleManager = this.StyleManager;
                editcardlist.ShowDialog();
                CardListComboBox.Items.Clear();
                MyCardLists_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bDeleteCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }
                int ind = CardListComboBox.Items.IndexOf(CardListComboBox.SelectedItem.ToString());
                string name = CardListComboBox.SelectedItem.ToString();
                db = new DataBase();
                db.DeleteCardList(NameTable, name, ind);
                CardListComboBox.Items.Remove(CardListComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bLearnCardList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CardListComboBox.SelectedItem == null)
                {
                    throw new Exception();
                }
                this.Deck = new CardList(CardListComboBox.SelectedItem.ToString());
                Deck.SetCurrent(0);
                db = new DataBase();
                int size = Convert.ToInt32(db.GetCountCardList(Deck));
                if (size < 3)
                    MessageBox.Show("Для того, чтобы учить колоду, в ней должно быть не менее трёх карт.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ReviewForm reviewform = new ReviewForm(Deck);
                    reviewform.StyleManager = this.StyleManager;
                    reviewform.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MyCardLists_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
           
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e) // обработчик событий
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        void TitlePageHandler(object sender, PrintPageEventArgs e) // обработчик событий
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void metroLink1_Click_1(object sender, EventArgs e)
        {
            if (CardListComboBox.Text == "")
                MessageBox.Show("Выберите колоду, с которой вы будете работать.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Deck = new CardList(CardListComboBox.Text);
                db.LoadCardList(Deck);
                result = Deck.GetName();
                for (int i = 0; i < this.Deck.GetSizeofList(); i++)
                {
                    result += '\n' + Deck.GetList(i).GetQuestion() + '\t' + Deck.GetList(i).GetAnswer();
                }
                // объект для печати
                PrintDocument printDocument = new PrintDocument();

                // обработчик события печати
                printDocument.PrintPage += PrintPageHandler;

                // диалог настройки печати
                PrintDialog printDialog = new PrintDialog();

                // установка объекта печати для его настройки
                printDialog.Document = printDocument;

                // если в диалоге было нажато ОК
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print(); // печатаем
            }
        }
    }
}
