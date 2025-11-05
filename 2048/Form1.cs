using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        Label[,] fields;
        Random rndNum = new Random();
    public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyDown += Form1_KeyDown;

            fields = new Label[,]
            {
                { field1, field2, field3, field4 },
                { field5, field6, field7, field8 },
                { field9, field10, field11, field12 },
                { field13, field14, field15, field16 }
            };

        }
        private void InitializeNewScore()
        {

            int[] num;
            while (true)
            {
                num = new int[] { rndNum.Next(0, 3), rndNum.Next(0, 3) };
                if (fields[num[0], num[1]].Text == "") break;
            }
            fields[num[0], num[1]].BackColor = Color.FromArgb(63, 196, 181);
            fields[num[0], num[1]].Text = "2";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNewScore();
            InitializeNewScore();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 3; x++)
                        {
                            for (int x2 = x + 1; x2 < 4; x2++)
                            {
                                if (fields[y, x].Text == "" && fields[y, x2].Text != "")
                                {
                                    fields[y, x].BackColor = fields[y, x2].BackColor;
                                    fields[y, x].Text = fields[y, x2].Text;
                                    fields[y, x2].Text = "";
                                    fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                }
                                else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y, x2].Text) {
                                    int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                    fields[y, x].BackColor = Color.FromArgb(62, 40 + (5 * int.Parse(fields[y, x].Text)), 97);
                                    fields[y, x].Text = Convert.ToString(value);
                                    fields[y, x2].Text = "";
                                    fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                }
                            }
                        }
                    }
                    InitializeNewScore();
                    break;
                case Keys.D:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 3; x >= 0; x--)
                        {
                            for (int x2 = x-1; x2 >= 0; x2--)
                            {
                                if (fields[y, x].Text == "" && fields[y, x2].Text != "")
                                {
                                    fields[y, x].BackColor = fields[y, x2].BackColor;
                                    fields[y, x].Text = fields[y, x2].Text;
                                    fields[y, x2].Text = "";
                                    fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                }
                                else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y, x2].Text)
                                {
                                    int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                    fields[y, x].BackColor = Color.FromArgb(62, 40 + (5 * int.Parse(fields[y, x].Text)), 97);
                                    fields[y, x].Text = Convert.ToString(value);
                                    fields[y, x2].Text = "";
                                    fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                }
                            }
                        }
                    }
                    InitializeNewScore();
                    break;
                case Keys.W:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 3; x >= 0; x--)
                        {
                            for (int y2 = y + 1; y2 < 4; y2++)
                            {
                                if (fields[y, x].Text == "" && fields[y2, x].Text != "")
                                {
                                    fields[y, x].BackColor = fields[y2, x].BackColor;
                                    fields[y, x].Text = fields[y2, x].Text;
                                    fields[y2, x].Text = "";
                                    fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                }
                                else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y2, x].Text)
                                {
                                    int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                    fields[y, x].BackColor = Color.FromArgb(62, 40 + (5 * int.Parse(fields[y, x].Text)), 97);
                                    fields[y, x].Text = Convert.ToString(value);
                                    fields[y2, x].Text = "";
                                    fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                }
                            }   
                        }
                    }
                    InitializeNewScore();
                    break;
                case Keys.S:
                    for (int y = 3; y > 0; y--)
                    {
                        for (int x = 3; x >= 0; x--)
                        {
                            for (int y2 = y - 1; y2 >=0; y2--)
                            {
                                if (fields[y, x].Text == "" && fields[y2, x].Text != "")
                                {
                                    fields[y, x].BackColor = fields[y2, x].BackColor;
                                    fields[y, x].Text = fields[y2, x].Text;
                                    fields[y2, x].Text = "";
                                    fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                }
                                else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y2, x].Text)
                                {
                                    int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                    fields[y, x].BackColor = Color.FromArgb(62, 40 + (5 * int.Parse(fields[y, x].Text)), 97);
                                    fields[y, x].Text = Convert.ToString(value);
                                    fields[y2, x].Text = "";
                                    fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                }
                            }
                        }
                    }
                    InitializeNewScore();
                    break;
            }
        }

        private void ChangeTheme_Click(object sender, EventArgs e)
        {

            int[,] colors = new int[,] { };
            ;

            if (ChangeTheme.Text == "🌙")
            {
                ChangeTheme.Text = "🔅";
                colors = new int[,]
                {
        { 112, 94, 77 },
        { 255, 252, 245 },
        { 199, 196, 189 },
        { 112, 94, 77 },
        { 255, 252, 245 }
                };
                for (int y = 0; y < 4; y++) for (int x = 3; x >= 0; x--) fields[y, x].ForeColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            }
            else
            {
                ChangeTheme.Text = "🌙";
                colors = new int[,]
                {
        { 62, 40, 97 },
        { 102, 59, 143 },
        { 180, 161, 212 },
        { 255, 255, 255 },
        { 63, 196, 181 }
                };
                for (int y = 0; y < 4; y++) for (int x = 3; x >= 0; x--) fields[y, x].ForeColor = Color.FromArgb(255, 255, 255);
            }

            ChangeTheme.ForeColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            this.BackColor = Color.FromArgb(colors[1, 0], colors[1, 1], colors[1, 2]);
            NewGameButton.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            NewGameButton.ForeColor = Color.FromArgb(colors[2, 0], colors[2, 1], colors[2, 2]);
            GameName.ForeColor = Color.FromArgb(colors[3, 0], colors[3, 1], colors[3, 2]);
            DecoratinLine2.ForeColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            DecorationLine1.ForeColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            Comment.ForeColor = Color.FromArgb(colors[2, 0], colors[2, 1], colors[2, 2]);
            Score.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            ScoreNum.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            Best.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            BestNum.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            Best.ForeColor = Color.FromArgb(colors[2, 0], colors[2, 1], colors[2, 2]);
            BestNum.ForeColor = Color.FromArgb(colors[2, 0], colors[2, 1], colors[2, 2]);
            BGfields.BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
            for (int y = 0; y < 4; y++)
            {
                for (int x = 3; x >= 0; x--)
                {
                    if (fields[y, x].Text == "") fields[y, x].BackColor = Color.FromArgb(colors[0, 0], colors[0, 1], colors[0, 2]);
                    else fields[y, x].BackColor = Color.FromArgb(colors[4, 0], colors[4, 1], colors[4, 2]);
                }
            }
        }
    }
}
