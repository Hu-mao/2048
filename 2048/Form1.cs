using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
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
        private int totalScore = 0;
        private int bestScore = 0;
        private string filePath = "bestscore.txt";
        //public dms
        FileStream stream = null;
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
        private void HardColorChanging(Label label)
        {
            if (ChangeTheme.Text == "🔅")
            {
                if (label.Text == "2")
                {
                    label.BackColor = Color.FromArgb(226, 224, 201);
                }
                else if (label.Text == "4")
                {
                    label.BackColor = Color.FromArgb(226, 213, 155);
                }
                else if (label.Text == "8")
                {
                    label.BackColor = Color.FromArgb(248, 184, 122);
                }
                else if (label.Text == "16")
                {
                    label.BackColor = Color.FromArgb(245, 159, 114);
                }
                else if (label.Text == "32")
                {
                    label.BackColor = Color.FromArgb(244, 130, 96);
                }
                else if (label.Text == "64")
                {
                    label.BackColor = Color.FromArgb(243, 124, 68);
                }
                else if (label.Text == "128")
                {
                    label.BackColor = Color.FromArgb(240, 215, 70);
                }
                else if (label.Text == "256")
                {
                    label.BackColor = Color.FromArgb(240, 210, 75);
                }
                else if (label.Text == "512")
                {
                    label.BackColor = Color.FromArgb(243, 210, 87);
                }
                else if (label.Text == "1024")
                {
                    label.BackColor = Color.FromArgb(241, 213, 92);
                }
                else if (label.Text == "2048")
                {
                    label.BackColor = Color.FromArgb(244, 216, 124);
                }
            }
            else if (ChangeTheme.Text == "🌙")
            {
                if (label.Text == "2")
                {
                    label.BackColor = Color.FromArgb(63, 196, 181);
                }
                else if (label.Text == "4")
                {
                    label.BackColor = Color.FromArgb(63, 106, 101);
                }
                else if (label.Text == "8")
                {
                    label.BackColor = Color.FromArgb(63, 156, 100);
                }
                else if (label.Text == "16")
                {
                    label.BackColor = Color.FromArgb(63, 106, 100);
                }
                else if (label.Text == "32")
                {
                    label.BackColor = Color.FromArgb(63, 106, 50);
                }
                else if (label.Text == "64")
                {
                    label.BackColor = Color.FromArgb(103, 106, 50);
                }
                else if (label.Text == "128")
                {
                    label.BackColor = Color.FromArgb(103, 156, 50);
                }
                else if (label.Text == "256")
                {
                    label.BackColor = Color.FromArgb(153, 156, 50);
                }
                else if (label.Text == "512")
                {
                    label.BackColor = Color.FromArgb(153, 156, 100);
                }
                else if (label.Text == "1024")
                {
                    label.BackColor = Color.FromArgb(153, 256, 100);
                }
                else if (label.Text == "2048")
                {
                    label.BackColor = Color.FromArgb(253, 256, 100);
                }
            }
        }

        private void UpdateBestScore()
        {
            if (totalScore > bestScore)
            {
                bestScore = totalScore;
                BestNum.Text = bestScore.ToString();
                stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    int textScore = 0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line != null)
                        {
                            textScore = Convert.ToInt32(line);
                            if (textScore > bestScore)
                            {
                                bestScore = textScore;

                            }
                        }
                    }
                    BestNum.Text = bestScore.ToString();
                }
                ;


                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(bestScore);
                }
                ;

            }
        }
        private bool IfICanMove()
        {
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (fields[y, x].Text == "")
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
        private void InitializeNewScore()
        {

            int[] num;
            int newnum = rndNum.Next(0, 2);
            while (true)
            {
                num = new int[] { rndNum.Next(0, 4), rndNum.Next(0, 4) };
                if (fields[num[0], num[1]].Text == "") break;
            }
            if (ChangeTheme.Text == "🌙")
            {
                fields[num[0], num[1]].BackColor = Color.FromArgb(63, 196, 181);
            }
            else if (ChangeTheme.Text == "🔅")
            {
                fields[num[0], num[1]].BackColor = Color.FromArgb(193, 176, 157);
            }
            if (newnum == 0)
            {
                fields[num[0], num[1]].Text = "2";
            }
            else
            {
                fields[num[0], num[1]].Text = "4";
                if (ChangeTheme.Text == "🌙")
                {
                    fields[num[0], num[1]].BackColor = Color.FromArgb(63, 106, 101);
                }
                else if (ChangeTheme.Text == "🔅")
                {
                    fields[num[0], num[1]].BackColor = Color.FromArgb(193, 126, 117);
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeNewScore();
            InitializeNewScore();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (IfICanMove())
            {
                bool moved = false;
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
                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(112, 94, 77);
                                        }

                                        moved = true;
                                    }
                                    else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y, x2].Text)
                                    {
                                        int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                        HardColorChanging(fields[y, x]);
                                        if (fields[y, x].Text == "1024" || fields[y, x].Text == "2048")
                                        {
                                            fields[y, x].Font = new Font(fields[y, x].Font.FontFamily, 8, fields[y, x].Font.Style);
                                        }
                                        fields[y, x].Text = Convert.ToString(value);
                                        fields[y, x2].Text = "";
                                        totalScore += value;
                                        ScoreNum.Text = totalScore.ToString();

                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (moved) InitializeNewScore();
                        moved = false;
                        break;
                    case Keys.D:
                        for (int y = 0; y < 4; y++)
                        {
                            for (int x = 3; x >= 0; x--)
                            {
                                for (int x2 = x - 1; x2 >= 0; x2--)
                                {
                                    if (fields[y, x].Text == "" && fields[y, x2].Text != "")
                                    {
                                        fields[y, x].BackColor = fields[y, x2].BackColor;
                                        fields[y, x].Text = fields[y, x2].Text;
                                        fields[y, x2].Text = "";
                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                    }
                                    else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y, x2].Text)
                                    {
                                        int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                        HardColorChanging(fields[y, x]);
                                        if (fields[y, x].Text == "1024" || fields[y, x].Text == "2048")
                                        {
                                            fields[y, x].Font = new Font(fields[y, x].Font.FontFamily, 8, fields[y, x].Font.Style);
                                        }
                                        fields[y, x].Text = Convert.ToString(value);
                                        fields[y, x2].Text = "";
                                        totalScore += value;
                                        ScoreNum.Text = totalScore.ToString();

                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y, x2].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (moved) InitializeNewScore();
                        moved = false;
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
                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                    }
                                    else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y2, x].Text)
                                    {
                                        int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                        HardColorChanging(fields[y, x]);
                                        if (fields[y, x].Text == "1024" || fields[y, x].Text == "2048")
                                        {
                                            fields[y, x].Font = new Font(fields[y, x].Font.FontFamily, 8, fields[y, x].Font.Style);
                                        }
                                        fields[y, x].Text = Convert.ToString(value);
                                        fields[y2, x].Text = "";
                                        totalScore += value;
                                        ScoreNum.Text = totalScore.ToString();

                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (moved) InitializeNewScore();
                        moved = false;
                        break;
                    case Keys.S:
                        for (int y = 3; y > 0; y--)
                        {
                            for (int x = 3; x >= 0; x--)
                            {
                                for (int y2 = y - 1; y2 >= 0; y2--)
                                {
                                    if (fields[y, x].Text == "" && fields[y2, x].Text != "")
                                    {
                                        fields[y, x].BackColor = fields[y2, x].BackColor;
                                        fields[y, x].Text = fields[y2, x].Text;
                                        fields[y2, x].Text = "";
                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                    }
                                    else if (fields[y, x].Text != "" && fields[y, x].Text == fields[y2, x].Text)
                                    {
                                        int value = Convert.ToInt32(fields[y, x].Text) * 2;
                                        HardColorChanging(fields[y, x]);
                                        if (fields[y, x].Text == "1024" || fields[y, x].Text == "2048")
                                        {
                                            fields[y, x].Font = new Font(fields[y, x].Font.FontFamily, 8, fields[y, x].Font.Style);
                                        }
                                        fields[y, x].Text = Convert.ToString(value);
                                        fields[y2, x].Text = "";
                                        totalScore += value;
                                        ScoreNum.Text = totalScore.ToString();

                                        if (ChangeTheme.Text == "🌙")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(62, 40, 97);
                                        }
                                        else if (ChangeTheme.Text == "🔅")
                                        {
                                            fields[y2, x].BackColor = Color.FromArgb(112, 94, 77);
                                        }
                                        moved = true;
                                        break;

                                    }
                                }
                            }
                        }
                        if (moved) InitializeNewScore();
                        moved = false;
                        break;
                }
            }
            else
            {
                MessageBox.Show("You Lose!");
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

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            //File stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //using (StreamWriter writer = new StreamWriter()
            totalScore = 0;
            ScoreNum.Text = totalScore.ToString();
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (ChangeTheme.Text == "🌙")
                    {
                        fields[y, x].BackColor = Color.FromArgb(62, 40, 97);
                        fields[y, x].Text = "";
                    }

                    else if (ChangeTheme.Text == "🔅")
                    {
                        fields[y, x].BackColor = Color.FromArgb(112, 94, 77);
                        fields[y, x].Text = "";
                    }
                }
            }
            Form1_Load(sender, e);
        }

    }
}
