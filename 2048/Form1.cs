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
                            }
                        }
                    }
                    InitializeNewScore();
                    break;
            }
        }
    }
}
