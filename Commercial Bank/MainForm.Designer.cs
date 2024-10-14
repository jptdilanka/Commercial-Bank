namespace Commercial_Bank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            depositebtn = new Button();
            button7 = new Button();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1586, 706);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(depositebtn);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1586, 89);
            panel1.TabIndex = 5;
            // 
            // depositebtn
            // 
            depositebtn.FlatAppearance.BorderSize = 0;
            depositebtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            depositebtn.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            depositebtn.FlatStyle = FlatStyle.Flat;
            depositebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositebtn.ForeColor = Color.Black;
            depositebtn.Location = new Point(1210, 15);
            depositebtn.Margin = new Padding(4);
            depositebtn.Name = "depositebtn";
            depositebtn.Size = new Size(127, 60);
            depositebtn.TabIndex = 8;
            depositebtn.Text = "Deposit";
            depositebtn.UseVisualStyleBackColor = true;
            depositebtn.Click += depositebtn_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(1017, 15);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(185, 60);
            button7.TabIndex = 6;
            button7.Text = "Member List";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 9);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1345, 15);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(228, 60);
            button4.TabIndex = 4;
            button4.Text = "Account Balance";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(846, 15);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(185, 60);
            button3.TabIndex = 3;
            button3.Text = "Actions";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(806, 134);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(185, 61);
            button6.TabIndex = 1;
            button6.Text = "Add Member";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(999, 134);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(185, 61);
            button5.TabIndex = 3;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 706);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button depositebtn;
    }
}