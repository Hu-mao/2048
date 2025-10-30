﻿namespace _2048
{
    partial class Form1
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
            this.GameName = new System.Windows.Forms.Label();
            this.DecorationLine1 = new System.Windows.Forms.Label();
            this.DecoratinLine2 = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreNum = new System.Windows.Forms.Label();
            this.BestNum = new System.Windows.Forms.Label();
            this.Best = new System.Windows.Forms.Label();
            this.field1 = new System.Windows.Forms.Label();
            this.field2 = new System.Windows.Forms.Label();
            this.field4 = new System.Windows.Forms.Label();
            this.field3 = new System.Windows.Forms.Label();
            this.field7 = new System.Windows.Forms.Label();
            this.field8 = new System.Windows.Forms.Label();
            this.field6 = new System.Windows.Forms.Label();
            this.field5 = new System.Windows.Forms.Label();
            this.field15 = new System.Windows.Forms.Label();
            this.field16 = new System.Windows.Forms.Label();
            this.field14 = new System.Windows.Forms.Label();
            this.field13 = new System.Windows.Forms.Label();
            this.field11 = new System.Windows.Forms.Label();
            this.field12 = new System.Windows.Forms.Label();
            this.field10 = new System.Windows.Forms.Label();
            this.field9 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 54F);
            this.GameName.ForeColor = System.Drawing.Color.White;
            this.GameName.Location = new System.Drawing.Point(203, -4);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(241, 102);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "2048";
            this.GameName.Click += new System.EventHandler(this.GameName_Click);
            // 
            // DecorationLine1
            // 
            this.DecorationLine1.AutoSize = true;
            this.DecorationLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecorationLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.DecorationLine1.Location = new System.Drawing.Point(434, 32);
            this.DecorationLine1.Name = "DecorationLine1";
            this.DecorationLine1.Size = new System.Drawing.Size(122, 76);
            this.DecorationLine1.TabIndex = 1;
            this.DecorationLine1.Text = "     ";
            this.DecorationLine1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DecoratinLine2
            // 
            this.DecoratinLine2.AutoSize = true;
            this.DecoratinLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecoratinLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.DecoratinLine2.Location = new System.Drawing.Point(86, 32);
            this.DecoratinLine2.Name = "DecoratinLine2";
            this.DecoratinLine2.Size = new System.Drawing.Size(122, 76);
            this.DecoratinLine2.TabIndex = 2;
            this.DecoratinLine2.Text = "     ";
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.NewGameButton.Location = new System.Drawing.Point(95, 139);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(131, 48);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "NEW GAME";
            this.NewGameButton.UseVisualStyleBackColor = false;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.Score.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(358, 139);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(90, 25);
            this.Score.TabIndex = 4;
            this.Score.Text = "SCORE";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScoreNum
            // 
            this.ScoreNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.ScoreNum.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreNum.ForeColor = System.Drawing.Color.White;
            this.ScoreNum.Location = new System.Drawing.Point(358, 162);
            this.ScoreNum.Name = "ScoreNum";
            this.ScoreNum.Size = new System.Drawing.Size(90, 25);
            this.ScoreNum.TabIndex = 5;
            this.ScoreNum.Text = "0";
            this.ScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BestNum
            // 
            this.BestNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.BestNum.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.BestNum.Location = new System.Drawing.Point(448, 162);
            this.BestNum.Name = "BestNum";
            this.BestNum.Size = new System.Drawing.Size(90, 25);
            this.BestNum.TabIndex = 7;
            this.BestNum.Text = "0";
            this.BestNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Best
            // 
            this.Best.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.Best.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Best.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.Best.Location = new System.Drawing.Point(448, 139);
            this.Best.Name = "Best";
            this.Best.Size = new System.Drawing.Size(90, 25);
            this.Best.TabIndex = 6;
            this.Best.Text = "BEST";
            this.Best.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field1.ForeColor = System.Drawing.Color.White;
            this.field1.Location = new System.Drawing.Point(95, 222);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(95, 95);
            this.field1.TabIndex = 12;
            this.field1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field2.ForeColor = System.Drawing.Color.White;
            this.field2.Location = new System.Drawing.Point(213, 222);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(95, 95);
            this.field2.TabIndex = 13;
            this.field2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field4.ForeColor = System.Drawing.Color.White;
            this.field4.Location = new System.Drawing.Point(443, 222);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(95, 95);
            this.field4.TabIndex = 14;
            this.field4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field3.ForeColor = System.Drawing.Color.White;
            this.field3.Location = new System.Drawing.Point(330, 222);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(95, 95);
            this.field3.TabIndex = 15;
            this.field3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field7.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field7.ForeColor = System.Drawing.Color.White;
            this.field7.Location = new System.Drawing.Point(330, 336);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(95, 95);
            this.field7.TabIndex = 19;
            this.field7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field8.ForeColor = System.Drawing.Color.White;
            this.field8.Location = new System.Drawing.Point(443, 336);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(95, 95);
            this.field8.TabIndex = 18;
            this.field8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field6.ForeColor = System.Drawing.Color.White;
            this.field6.Location = new System.Drawing.Point(213, 336);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(95, 95);
            this.field6.TabIndex = 17;
            this.field6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field5.ForeColor = System.Drawing.Color.White;
            this.field5.Location = new System.Drawing.Point(95, 336);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(95, 95);
            this.field5.TabIndex = 16;
            this.field5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field15
            // 
            this.field15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field15.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field15.ForeColor = System.Drawing.Color.White;
            this.field15.Location = new System.Drawing.Point(330, 559);
            this.field15.Name = "field15";
            this.field15.Size = new System.Drawing.Size(95, 95);
            this.field15.TabIndex = 27;
            this.field15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field16
            // 
            this.field16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field16.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field16.ForeColor = System.Drawing.Color.White;
            this.field16.Location = new System.Drawing.Point(443, 559);
            this.field16.Name = "field16";
            this.field16.Size = new System.Drawing.Size(95, 95);
            this.field16.TabIndex = 26;
            this.field16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field14
            // 
            this.field14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field14.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field14.ForeColor = System.Drawing.Color.White;
            this.field14.Location = new System.Drawing.Point(213, 559);
            this.field14.Name = "field14";
            this.field14.Size = new System.Drawing.Size(95, 95);
            this.field14.TabIndex = 25;
            this.field14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field13
            // 
            this.field13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field13.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field13.ForeColor = System.Drawing.Color.White;
            this.field13.Location = new System.Drawing.Point(95, 559);
            this.field13.Name = "field13";
            this.field13.Size = new System.Drawing.Size(95, 95);
            this.field13.TabIndex = 24;
            this.field13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field11
            // 
            this.field11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field11.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field11.ForeColor = System.Drawing.Color.White;
            this.field11.Location = new System.Drawing.Point(330, 445);
            this.field11.Name = "field11";
            this.field11.Size = new System.Drawing.Size(95, 95);
            this.field11.TabIndex = 23;
            this.field11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field12
            // 
            this.field12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field12.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field12.ForeColor = System.Drawing.Color.White;
            this.field12.Location = new System.Drawing.Point(443, 445);
            this.field12.Name = "field12";
            this.field12.Size = new System.Drawing.Size(95, 95);
            this.field12.TabIndex = 22;
            this.field12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field10
            // 
            this.field10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field10.ForeColor = System.Drawing.Color.White;
            this.field10.Location = new System.Drawing.Point(213, 445);
            this.field10.Name = "field10";
            this.field10.Size = new System.Drawing.Size(95, 95);
            this.field10.TabIndex = 21;
            this.field10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // field9
            // 
            this.field9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.field9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field9.ForeColor = System.Drawing.Color.White;
            this.field9.Location = new System.Drawing.Point(95, 445);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(95, 95);
            this.field9.TabIndex = 20;
            this.field9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("Berlin Sans FB Demi", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.Comment.Location = new System.Drawing.Point(201, 84);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(241, 27);
            this.Comment.TabIndex = 28;
            this.Comment.Text = "A Simple Challenge, Endless Depth";
            this.Comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(59)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(637, 674);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.field15);
            this.Controls.Add(this.field16);
            this.Controls.Add(this.field14);
            this.Controls.Add(this.field13);
            this.Controls.Add(this.field11);
            this.Controls.Add(this.field12);
            this.Controls.Add(this.field10);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.BestNum);
            this.Controls.Add(this.Best);
            this.Controls.Add(this.ScoreNum);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.DecoratinLine2);
            this.Controls.Add(this.DecorationLine1);
            this.Controls.Add(this.GameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label DecorationLine1;
        private System.Windows.Forms.Label DecoratinLine2;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreNum;
        private System.Windows.Forms.Label BestNum;
        private System.Windows.Forms.Label Best;
        private System.Windows.Forms.Label field1;
        private System.Windows.Forms.Label field2;
        private System.Windows.Forms.Label field4;
        private System.Windows.Forms.Label field3;
        private System.Windows.Forms.Label field7;
        private System.Windows.Forms.Label field8;
        private System.Windows.Forms.Label field6;
        private System.Windows.Forms.Label field5;
        private System.Windows.Forms.Label field15;
        private System.Windows.Forms.Label field16;
        private System.Windows.Forms.Label field14;
        private System.Windows.Forms.Label field13;
        private System.Windows.Forms.Label field11;
        private System.Windows.Forms.Label field12;
        private System.Windows.Forms.Label field10;
        private System.Windows.Forms.Label field9;
        private System.Windows.Forms.Label Comment;
    }
}

