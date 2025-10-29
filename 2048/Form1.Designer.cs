namespace _2048
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreNum = new System.Windows.Forms.Label();
            this.BestNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(434, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(86, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "     ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.button1.Location = new System.Drawing.Point(95, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "new game";
            this.button1.UseVisualStyleBackColor = false;
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(448, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "BEST";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 95);
            this.label10.TabIndex = 12;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(213, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 95);
            this.label3.TabIndex = 13;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 95);
            this.label5.TabIndex = 14;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(330, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 95);
            this.label6.TabIndex = 15;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(330, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 95);
            this.label7.TabIndex = 19;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(443, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 95);
            this.label8.TabIndex = 18;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(213, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 95);
            this.label9.TabIndex = 17;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(95, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 95);
            this.label11.TabIndex = 16;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(330, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 95);
            this.label12.TabIndex = 27;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(443, 559);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 95);
            this.label13.TabIndex = 26;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(213, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 95);
            this.label14.TabIndex = 25;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label15.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(95, 559);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 95);
            this.label15.TabIndex = 24;
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label16.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(330, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 95);
            this.label16.TabIndex = 23;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label17.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(443, 445);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 95);
            this.label17.TabIndex = 22;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label18.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(213, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 95);
            this.label18.TabIndex = 21;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(40)))), ((int)(((byte)(97)))));
            this.label19.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(95, 445);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 95);
            this.label19.TabIndex = 20;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Berlin Sans FB Demi", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(161)))), ((int)(((byte)(212)))));
            this.label20.Location = new System.Drawing.Point(201, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(241, 27);
            this.label20.TabIndex = 28;
            this.label20.Text = "A Simple Challenge, Endless Depth";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(59)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(637, 674);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BestNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScoreNum);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreNum;
        private System.Windows.Forms.Label BestNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

