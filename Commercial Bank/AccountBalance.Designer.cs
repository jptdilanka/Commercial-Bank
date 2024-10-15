namespace Commercial_Bank
{
    partial class AccountBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountBalance));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            MessageLabel = new Label();
            searchbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            detailspanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            amount = new Label();
            namelabel = new Label();
            niclabel = new Label();
            acclabel = new Label();
            pno = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            AccountNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            detailspanel.SuspendLayout();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.BackColor = Color.Transparent;
            MessageLabel.Font = new Font("Times New Roman", 13.8F);
            MessageLabel.Location = new Point(282, 471);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(43, 33);
            MessageLabel.TabIndex = 22;
            MessageLabel.Text = "00";
            MessageLabel.Visible = false;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.DisabledState.BorderColor = Color.DarkGray;
            searchbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            searchbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchbtn.FillColor = Color.FromArgb(128, 64, 64);
            searchbtn.Font = new Font("Segoe UI", 9F);
            searchbtn.ForeColor = Color.White;
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.ImageOffset = new Point(2, 0);
            searchbtn.ImageSize = new Size(50, 50);
            searchbtn.Location = new Point(700, 112);
            searchbtn.Name = "searchbtn";
            searchbtn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            searchbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            searchbtn.Size = new Size(66, 67);
            searchbtn.TabIndex = 21;
            searchbtn.Click += searchbtn_Click;
            // 
            // detailspanel
            // 
            detailspanel.BorderColor = Color.Black;
            detailspanel.BorderRadius = 1;
            detailspanel.Controls.Add(amount);
            detailspanel.Controls.Add(namelabel);
            detailspanel.Controls.Add(niclabel);
            detailspanel.Controls.Add(acclabel);
            detailspanel.Controls.Add(pno);
            detailspanel.Controls.Add(label2);
            detailspanel.Controls.Add(label6);
            detailspanel.Controls.Add(label3);
            detailspanel.Controls.Add(label4);
            detailspanel.Controls.Add(label5);
            detailspanel.CustomizableEdges = customizableEdges2;
            detailspanel.FillColor = Color.White;
            detailspanel.FillColor2 = Color.FromArgb(192, 255, 255);
            detailspanel.Location = new Point(71, 209);
            detailspanel.Name = "detailspanel";
            detailspanel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            detailspanel.Size = new Size(695, 242);
            detailspanel.TabIndex = 20;
            detailspanel.Visible = false;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.BackColor = Color.Transparent;
            amount.Font = new Font("Times New Roman", 13.8F);
            amount.Location = new Point(211, 191);
            amount.Name = "amount";
            amount.Size = new Size(29, 33);
            amount.TabIndex = 16;
            amount.Text = "0";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.BackColor = Color.Transparent;
            namelabel.Font = new Font("Times New Roman", 13.8F);
            namelabel.Location = new Point(211, 10);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(29, 33);
            namelabel.TabIndex = 12;
            namelabel.Text = "_";
            // 
            // niclabel
            // 
            niclabel.AutoSize = true;
            niclabel.BackColor = Color.Transparent;
            niclabel.Font = new Font("Times New Roman", 13.8F);
            niclabel.Location = new Point(211, 55);
            niclabel.Name = "niclabel";
            niclabel.Size = new Size(29, 33);
            niclabel.TabIndex = 13;
            niclabel.Text = "0";
            // 
            // acclabel
            // 
            acclabel.AutoSize = true;
            acclabel.BackColor = Color.Transparent;
            acclabel.Font = new Font("Times New Roman", 13.8F);
            acclabel.Location = new Point(211, 97);
            acclabel.Name = "acclabel";
            acclabel.Size = new Size(29, 33);
            acclabel.TabIndex = 14;
            acclabel.Text = "_";
            // 
            // pno
            // 
            pno.AutoSize = true;
            pno.BackColor = Color.Transparent;
            pno.Font = new Font("Times New Roman", 13.8F);
            pno.Location = new Point(211, 144);
            pno.Name = "pno";
            pno.Size = new Size(59, 33);
            pno.TabIndex = 15;
            pno.Text = "+94";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(94, 33);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(12, 191);
            label6.Name = "label6";
            label6.Size = new Size(126, 33);
            label6.TabIndex = 9;
            label6.Text = "Amount : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(84, 33);
            label3.TabIndex = 3;
            label3.Text = "NIC : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(189, 33);
            label4.TabIndex = 5;
            label4.Text = "Account Type : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(12, 144);
            label5.Name = "label5";
            label5.Size = new Size(203, 33);
            label5.TabIndex = 7;
            label5.Text = "Phone Number : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 136);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 19;
            label1.Text = "Enter The Account No :";
            // 
            // AccountNoTextBox
            // 
            AccountNoTextBox.CustomizableEdges = customizableEdges4;
            AccountNoTextBox.DefaultText = "";
            AccountNoTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            AccountNoTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            AccountNoTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            AccountNoTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            AccountNoTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            AccountNoTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountNoTextBox.ForeColor = Color.Black;
            AccountNoTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            AccountNoTextBox.Location = new Point(373, 125);
            AccountNoTextBox.Margin = new Padding(5);
            AccountNoTextBox.Name = "AccountNoTextBox";
            AccountNoTextBox.PasswordChar = '\0';
            AccountNoTextBox.PlaceholderText = "";
            AccountNoTextBox.SelectedText = "";
            AccountNoTextBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            AccountNoTextBox.Size = new Size(318, 54);
            AccountNoTextBox.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(236, 23);
            label8.Name = "label8";
            label8.Size = new Size(369, 43);
            label8.TabIndex = 27;
            label8.Text = "COMMERCIAL BANK";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(267, 60);
            label9.Name = "label9";
            label9.Size = new Size(291, 39);
            label9.TabIndex = 26;
            label9.Text = "Account Balance";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(516, 502);
            button4.Name = "button4";
            button4.Size = new Size(250, 46);
            button4.TabIndex = 28;
            button4.Text = "Back To Dashboard";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AccountBalance
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(828, 587);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(MessageLabel);
            Controls.Add(searchbtn);
            Controls.Add(detailspanel);
            Controls.Add(label1);
            Controls.Add(AccountNoTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountBalance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountBalance";
            Load += AccountBalance_Load;
            detailspanel.ResumeLayout(false);
            detailspanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MessageLabel;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn;
        private Guna.UI2.WinForms.Guna2GradientPanel detailspanel;
        private Label namelabel;
        private Label niclabel;
        private Label acclabel;
        private Label pno;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox AccountNoTextBox;
        private Label amount;
        private Label label8;
        private Label label9;
        private Button button4;
    }
}