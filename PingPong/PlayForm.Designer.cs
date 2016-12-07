namespace PingPong
{
    partial class PlayForm
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
            this.PlayPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.LeftWinsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RightWinsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayPictureBox
            // 
            this.PlayPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayPictureBox.Location = new System.Drawing.Point(12, 68);
            this.PlayPictureBox.Name = "PlayPictureBox";
            this.PlayPictureBox.Size = new System.Drawing.Size(787, 480);
            this.PlayPictureBox.TabIndex = 0;
            this.PlayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(437, 554);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(331, 553);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LeftWinsLabel
            // 
            this.LeftWinsLabel.AutoSize = true;
            this.LeftWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftWinsLabel.Location = new System.Drawing.Point(358, 27);
            this.LeftWinsLabel.Name = "LeftWinsLabel";
            this.LeftWinsLabel.Size = new System.Drawing.Size(24, 25);
            this.LeftWinsLabel.TabIndex = 3;
            this.LeftWinsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(388, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // RightWinsLabel
            // 
            this.RightWinsLabel.AutoSize = true;
            this.RightWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightWinsLabel.Location = new System.Drawing.Point(412, 27);
            this.RightWinsLabel.Name = "RightWinsLabel";
            this.RightWinsLabel.Size = new System.Drawing.Size(24, 25);
            this.RightWinsLabel.TabIndex = 5;
            this.RightWinsLabel.Text = "0";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 589);
            this.Controls.Add(this.RightWinsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftWinsLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PlayPictureBox);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.PlayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayPictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LeftWinsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RightWinsLabel;
    }
}