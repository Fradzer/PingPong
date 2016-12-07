namespace PingPong
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rdiobtnRed = new System.Windows.Forms.RadioButton();
            this.rdiobtnBlue = new System.Windows.Forms.RadioButton();
            this.rdiobtnSingleTracking = new System.Windows.Forms.RadioButton();
            this.rdiobtnManyTracking = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnElleBelirleme = new System.Windows.Forms.RadioButton();
            this.rdiobtnWhite = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chkboxDistance = new System.Windows.Forms.CheckBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.chkboxDistanceCoord = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkKoordinatiGoster = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(55, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(493, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(32, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Камера";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(23, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdiobtnRed
            // 
            this.rdiobtnRed.AutoSize = true;
            this.rdiobtnRed.Location = new System.Drawing.Point(8, 19);
            this.rdiobtnRed.Name = "rdiobtnRed";
            this.rdiobtnRed.Size = new System.Drawing.Size(84, 17);
            this.rdiobtnRed.TabIndex = 6;
            this.rdiobtnRed.TabStop = true;
            this.rdiobtnRed.Text = "Красный(R)";
            this.rdiobtnRed.UseVisualStyleBackColor = true;
            // 
            // rdiobtnBlue
            // 
            this.rdiobtnBlue.AutoSize = true;
            this.rdiobtnBlue.Location = new System.Drawing.Point(8, 65);
            this.rdiobtnBlue.Name = "rdiobtnBlue";
            this.rdiobtnBlue.Size = new System.Drawing.Size(69, 17);
            this.rdiobtnBlue.TabIndex = 7;
            this.rdiobtnBlue.TabStop = true;
            this.rdiobtnBlue.Text = "Синий(B)";
            this.rdiobtnBlue.UseVisualStyleBackColor = true;
            // 
            // rdiobtnSingleTracking
            // 
            this.rdiobtnSingleTracking.AutoSize = true;
            this.rdiobtnSingleTracking.Location = new System.Drawing.Point(14, 24);
            this.rdiobtnSingleTracking.Name = "rdiobtnSingleTracking";
            this.rdiobtnSingleTracking.Size = new System.Drawing.Size(82, 17);
            this.rdiobtnSingleTracking.TabIndex = 8;
            this.rdiobtnSingleTracking.TabStop = true;
            this.rdiobtnSingleTracking.Text = "Одиночный";
            this.rdiobtnSingleTracking.UseVisualStyleBackColor = true;
            // 
            // rdiobtnManyTracking
            // 
            this.rdiobtnManyTracking.AutoSize = true;
            this.rdiobtnManyTracking.Location = new System.Drawing.Point(14, 47);
            this.rdiobtnManyTracking.Name = "rdiobtnManyTracking";
            this.rdiobtnManyTracking.Size = new System.Drawing.Size(109, 17);
            this.rdiobtnManyTracking.TabIndex = 9;
            this.rdiobtnManyTracking.TabStop = true;
            this.rdiobtnManyTracking.Text = "Множественный";
            this.rdiobtnManyTracking.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(381, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(106, 224);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Координаты объекта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdiobtnSingleTracking);
            this.groupBox2.Controls.Add(this.rdiobtnManyTracking);
            this.groupBox2.Location = new System.Drawing.Point(238, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 77);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим слежения";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnElleBelirleme);
            this.groupBox3.Controls.Add(this.rdiobtnWhite);
            this.groupBox3.Controls.Add(this.rdiobtnRed);
            this.groupBox3.Controls.Add(this.rdiobtnBlue);
            this.groupBox3.Location = new System.Drawing.Point(394, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 114);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет";
            // 
            // rdbtnElleBelirleme
            // 
            this.rdbtnElleBelirleme.AutoSize = true;
            this.rdbtnElleBelirleme.Location = new System.Drawing.Point(8, 88);
            this.rdbtnElleBelirleme.Name = "rdbtnElleBelirleme";
            this.rdbtnElleBelirleme.Size = new System.Drawing.Size(50, 17);
            this.rdbtnElleBelirleme.TabIndex = 24;
            this.rdbtnElleBelirleme.TabStop = true;
            this.rdbtnElleBelirleme.Text = "Свой";
            this.rdbtnElleBelirleme.UseVisualStyleBackColor = true;
            // 
            // rdiobtnWhite
            // 
            this.rdiobtnWhite.AutoSize = true;
            this.rdiobtnWhite.Location = new System.Drawing.Point(8, 42);
            this.rdiobtnWhite.Name = "rdiobtnWhite";
            this.rdiobtnWhite.Size = new System.Drawing.Size(58, 17);
            this.rdiobtnWhite.TabIndex = 8;
            this.rdiobtnWhite.TabStop = true;
            this.rdiobtnWhite.Text = "Белый";
            this.rdiobtnWhite.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(17, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 115);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // chkboxDistance
            // 
            this.chkboxDistance.AutoSize = true;
            this.chkboxDistance.Location = new System.Drawing.Point(17, 20);
            this.chkboxDistance.Name = "chkboxDistance";
            this.chkboxDistance.Size = new System.Drawing.Size(117, 17);
            this.chkboxDistance.TabIndex = 16;
            this.chkboxDistance.Text = "Расстояние точек";
            this.chkboxDistance.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(136, 38);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 115);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            // 
            // chkboxDistanceCoord
            // 
            this.chkboxDistanceCoord.AutoSize = true;
            this.chkboxDistanceCoord.Location = new System.Drawing.Point(136, 20);
            this.chkboxDistanceCoord.Name = "chkboxDistanceCoord";
            this.chkboxDistanceCoord.Size = new System.Drawing.Size(119, 17);
            this.chkboxDistanceCoord.TabIndex = 18;
            this.chkboxDistanceCoord.Text = "Расстояние коорд";
            this.chkboxDistanceCoord.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox3);
            this.groupBox4.Controls.Add(this.chkboxDistance);
            this.groupBox4.Controls.Add(this.chkboxDistanceCoord);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Location = new System.Drawing.Point(595, 291);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 167);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Режим расстояния слежения";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(493, 293);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 165);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.Value = 41;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(526, 293);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 165);
            this.trackBar2.TabIndex = 22;
            this.trackBar2.Value = 196;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(559, 293);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 165);
            this.trackBar3.TabIndex = 23;
            this.trackBar3.Value = 212;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "B";
            // 
            // chkKoordinatiGoster
            // 
            this.chkKoordinatiGoster.AutoSize = true;
            this.chkKoordinatiGoster.Location = new System.Drawing.Point(381, 273);
            this.chkKoordinatiGoster.Name = "chkKoordinatiGoster";
            this.chkKoordinatiGoster.Size = new System.Drawing.Size(108, 17);
            this.chkKoordinatiGoster.TabIndex = 27;
            this.chkKoordinatiGoster.Text = "Показать коорд";
            this.chkKoordinatiGoster.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(564, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "0";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(394, 479);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 34;
            this.PlayButton.Text = "PLAY!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(860, 509);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkKoordinatiGoster);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdiobtnRed;
        private System.Windows.Forms.RadioButton rdiobtnBlue;
        private System.Windows.Forms.RadioButton rdiobtnSingleTracking;
        private System.Windows.Forms.RadioButton rdiobtnManyTracking;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdiobtnWhite;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox chkboxDistance;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox chkboxDistanceCoord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.RadioButton rdbtnElleBelirleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkKoordinatiGoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PlayButton;
    }
}

