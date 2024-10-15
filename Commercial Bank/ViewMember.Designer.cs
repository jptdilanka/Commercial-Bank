namespace Commercial_Bank
{
    partial class ViewMember
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            dgv = new DataGridView();
            searchtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1499, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 43);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(589, 41);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(369, 43);
            label2.TabIndex = 6;
            label2.Text = "COMMERCIAL BANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(660, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 39);
            label1.TabIndex = 5;
            label1.Text = "MEMBER LIST";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1074, 802);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(277, 47);
            button3.TabIndex = 49;
            button3.Text = "Back To Dashboard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            dgv.Location = new Point(16, 231);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1347, 545);
            dgv.TabIndex = 50;
            // 
            // searchtextbox
            // 
            searchtextbox.CustomizableEdges = customizableEdges1;
            searchtextbox.DefaultText = "";
            searchtextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchtextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchtextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchtextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchtextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchtextbox.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchtextbox.ForeColor = Color.Black;
            searchtextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchtextbox.Location = new Point(16, 161);
            searchtextbox.Margin = new Padding(7, 6, 7, 6);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.PasswordChar = '\0';
            searchtextbox.PlaceholderText = "Click here to Search The Member";
            searchtextbox.SelectedText = "";
            searchtextbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchtextbox.Size = new Size(441, 44);
            searchtextbox.TabIndex = 51;
            searchtextbox.TextChanged += searchtextbox_TextChanged;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 876);
            Controls.Add(searchtextbox);
            Controls.Add(dgv);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private DataGridView dgv;
        private Guna.UI2.WinForms.Guna2TextBox searchtextbox;
    }
}