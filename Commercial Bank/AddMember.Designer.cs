namespace Commercial_Bank
{
    partial class AddMember
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            PhoneTb = new TextBox();
            label6 = new Label();
            AgeTb = new TextBox();
            label7 = new Label();
            GenderCb = new ComboBox();
            label8 = new Label();
            AccTypeCb = new ComboBox();
            label9 = new Label();
            AccNoTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            label11 = new Label();
            button4 = new Button();
            label12 = new Label();
            emailtextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(616, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 39);
            label1.TabIndex = 2;
            label1.Text = "ADD NEW MEMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(589, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(369, 43);
            label2.TabIndex = 3;
            label2.Text = "COMMERCIAL BANK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1499, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 43);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.ForeColor = Color.Black;
            NameTb.Location = new Point(124, 259);
            NameTb.Margin = new Padding(4, 4, 4, 4);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(320, 33);
            NameTb.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(124, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(221, 34);
            label4.TabIndex = 6;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(591, 201);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(219, 34);
            label5.TabIndex = 8;
            label5.Text = "Phone Number";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.ForeColor = Color.Black;
            PhoneTb.Location = new Point(589, 259);
            PhoneTb.Margin = new Padding(4, 4, 4, 4);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(320, 33);
            PhoneTb.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(1088, 201);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 34);
            label6.TabIndex = 10;
            label6.Text = "Age";
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeTb.ForeColor = Color.Black;
            AgeTb.Location = new Point(1088, 259);
            AgeTb.Margin = new Padding(4, 4, 4, 4);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(320, 33);
            AgeTb.TabIndex = 9;
            AgeTb.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(124, 338);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 34);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(124, 392);
            GenderCb.Margin = new Padding(4, 4, 4, 4);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(320, 31);
            GenderCb.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(1100, 336);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(205, 34);
            label8.TabIndex = 15;
            label8.Text = "Account Type";
            // 
            // AccTypeCb
            // 
            AccTypeCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccTypeCb.FormattingEnabled = true;
            AccTypeCb.Items.AddRange(new object[] { "Savings Account", "Current Account" });
            AccTypeCb.Location = new Point(1089, 392);
            AccTypeCb.Margin = new Padding(4, 4, 4, 4);
            AccTypeCb.Name = "AccTypeCb";
            AccTypeCb.Size = new Size(320, 31);
            AccTypeCb.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(591, 338);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 34);
            label9.TabIndex = 18;
            label9.Text = "NIC";
            // 
            // AccNoTb
            // 
            AccNoTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNoTb.ForeColor = Color.Black;
            AccNoTb.Location = new Point(591, 394);
            AccNoTb.Margin = new Padding(4, 4, 4, 4);
            AccNoTb.Name = "AccNoTb";
            AccNoTb.Size = new Size(320, 33);
            AccNoTb.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(425, 655);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(196, 58);
            button1.TabIndex = 19;
            button1.Text = "Add";
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
            button2.Location = new Point(666, 655);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(196, 58);
            button2.TabIndex = 20;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(681, 731);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(166, 21);
            label10.TabIndex = 22;
            label10.Text = "DevelopedByBP_ERP";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(645, 752);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(239, 21);
            label11.TabIndex = 23;
            label11.Text = "contact:abcdefg@gmail.com";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(910, 655);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(251, 58);
            button4.TabIndex = 24;
            button4.Text = "Back To Dashboard";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(124, 481);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 34);
            label12.TabIndex = 26;
            label12.Text = "Email";
            // 
            // emailtextbox
            // 
            emailtextbox.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailtextbox.ForeColor = Color.Black;
            emailtextbox.Location = new Point(124, 538);
            emailtextbox.Margin = new Padding(4, 4, 4, 4);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(393, 33);
            emailtextbox.TabIndex = 25;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1560, 795);
            Controls.Add(label12);
            Controls.Add(emailtextbox);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(AccNoTb);
            Controls.Add(AccTypeCb);
            Controls.Add(label8);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AgeTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTb;
        private Label label4;
        private Label label5;
        private TextBox PhoneTb;
        private Label label6;
        private TextBox AgeTb;
        private Label label7;
        private ComboBox GenderCb;
        private Label label8;
        private ComboBox AccTypeCb;
        private Label label9;
        private TextBox AccNoTb;
        private Button button1;
        private Button button2;
        private Label label10;
        private Label label11;
        private Button button4;
        private Label label12;
        private TextBox emailtextbox;
    }
}