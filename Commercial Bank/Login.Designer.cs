﻿namespace Commercial_Bank
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UidTb = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            PassTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 80);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(488, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 43);
            label1.TabIndex = 1;
            label1.Text = "COMMERCIAL BANK";
            // 
            // UidTb
            // 
            UidTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UidTb.Location = new Point(419, 168);
            UidTb.Margin = new Padding(4, 4, 4, 4);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(458, 47);
            UidTb.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.person;
            pictureBox2.Location = new Point(876, 168);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(876, 268);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // PassTb
            // 
            PassTb.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassTb.Location = new Point(419, 268);
            PassTb.Margin = new Padding(4, 4, 4, 4);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '*';
            PassTb.Size = new Size(458, 47);
            PassTb.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(514, 362);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(140, 58);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(714, 362);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(140, 58);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 562);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(PassTb);
            Controls.Add(pictureBox2);
            Controls.Add(UidTb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox UidTb;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox PassTb;
        private Button button1;
        private Button button2;
    }
}
