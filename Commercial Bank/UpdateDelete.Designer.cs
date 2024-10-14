namespace Commercial_Bank
{
    partial class UpdateDelete
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AccNoTb = new TextBox();
            AccTypeCb = new ComboBox();
            label8 = new Label();
            GenderCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            AgeTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            label4 = new Label();
            NameTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            label9 = new Label();
            dgv = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(223, 536);
            button3.Name = "button3";
            button3.Size = new Size(100, 45);
            button3.TabIndex = 41;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(123, 536);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 40;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 536);
            button1.Name = "button1";
            button1.Size = new Size(97, 45);
            button1.TabIndex = 39;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AccNoTb
            // 
            AccNoTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNoTb.ForeColor = Color.Black;
            AccNoTb.Location = new Point(42, 395);
            AccNoTb.Name = "AccNoTb";
            AccNoTb.Size = new Size(257, 33);
            AccNoTb.TabIndex = 37;
            // 
            // AccTypeCb
            // 
            AccTypeCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccTypeCb.FormattingEnabled = true;
            AccTypeCb.Items.AddRange(new object[] { "Savings Account", "Current Account" });
            AccTypeCb.Location = new Point(42, 467);
            AccTypeCb.Name = "AccTypeCb";
            AccTypeCb.Size = new Size(257, 31);
            AccTypeCb.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(42, 434);
            label8.Name = "label8";
            label8.Size = new Size(153, 24);
            label8.TabIndex = 35;
            label8.Text = "Account Type";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(42, 331);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(257, 31);
            GenderCb.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(42, 307);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 33;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(42, 243);
            label6.Name = "label6";
            label6.Size = new Size(53, 24);
            label6.TabIndex = 32;
            label6.Text = "Age";
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeTb.ForeColor = Color.Black;
            AgeTb.Location = new Point(42, 276);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(257, 33);
            AgeTb.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(42, 179);
            label5.Name = "label5";
            label5.Size = new Size(166, 24);
            label5.TabIndex = 30;
            label5.Text = "Phone Number";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.ForeColor = Color.Black;
            PhoneTb.Location = new Point(42, 212);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(257, 33);
            PhoneTb.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(42, 115);
            label4.Name = "label4";
            label4.Size = new Size(169, 24);
            label4.TabIndex = 28;
            label4.Text = "Member Name";
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.ForeColor = Color.Black;
            NameTb.Location = new Point(42, 148);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(257, 33);
            NameTb.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1658, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 43);
            label3.TabIndex = 26;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(827, 17);
            label2.Name = "label2";
            label2.Size = new Size(369, 43);
            label2.TabIndex = 25;
            label2.Text = "COMMERCIAL BANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(791, 54);
            label1.Name = "label1";
            label1.Size = new Size(440, 39);
            label1.TabIndex = 24;
            label1.Text = "UPDATE OR DELETE MEMBER";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(192, 0, 0);
            label12.Location = new Point(820, 92);
            label12.Name = "label12";
            label12.Size = new Size(382, 24);
            label12.TabIndex = 45;
            label12.Text = "Click On The Member To Be Deleted";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(42, 371);
            label9.Name = "label9";
            label9.Size = new Size(190, 24);
            label9.TabIndex = 46;
            label9.Text = "Account Number";
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.GridColor = SystemColors.HotTrack;
            dgv.Location = new Point(338, 124);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1347, 545);
            dgv.TabIndex = 47;
            dgv.CellContentClick += MemberSDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(123, 587);
            button4.Name = "button4";
            button4.Size = new Size(94, 45);
            button4.TabIndex = 48;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1713, 717);
            Controls.Add(button4);
            Controls.Add(dgv);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Name = "UpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox AccNoTb;
        private ComboBox AccTypeCb;
        private Label label8;
        private ComboBox GenderCb;
        private Label label7;
        private Label label6;
        private TextBox AgeTb;
        private Label label5;
        private TextBox PhoneTb;
        private Label label4;
        private TextBox NameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Label label9;
        private DataGridView dgv;
        private Button button4;
    }
}