namespace Commercial_Bank
{
    partial class ChatbotForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatbotForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            messagebox = new Guna.UI2.WinForms.Guna2TextBox();
            chatRichTextBox = new RichTextBox();
            label1 = new Label();
            searchbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // messagebox
            // 
            messagebox.CustomizableEdges = customizableEdges1;
            messagebox.DefaultText = "";
            messagebox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            messagebox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            messagebox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            messagebox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            messagebox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            messagebox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messagebox.ForeColor = Color.Black;
            messagebox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            messagebox.Location = new Point(29, 105);
            messagebox.Margin = new Padding(4);
            messagebox.Name = "messagebox";
            messagebox.PasswordChar = '\0';
            messagebox.PlaceholderText = "Type your Message....";
            messagebox.SelectedText = "";
            messagebox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            messagebox.Size = new Size(323, 48);
            messagebox.TabIndex = 0;
            messagebox.KeyDown += messagebox_KeyDown;
            // 
            // chatRichTextBox
            // 
            chatRichTextBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chatRichTextBox.Location = new Point(29, 189);
            chatRichTextBox.Name = "chatRichTextBox";
            chatRichTextBox.Size = new Size(385, 360);
            chatRichTextBox.TabIndex = 2;
            chatRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(341, 26);
            label1.TabIndex = 3;
            label1.Text = "ChatBot For Commericial Bank";
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Transparent;
            searchbtn.Cursor = Cursors.Hand;
            searchbtn.DisabledState.BorderColor = Color.DarkGray;
            searchbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            searchbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchbtn.FillColor = Color.Blue;
            searchbtn.Font = new Font("Segoe UI", 9F);
            searchbtn.ForeColor = Color.White;
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.ImageOffset = new Point(2, 0);
            searchbtn.ImageSize = new Size(50, 50);
            searchbtn.Location = new Point(359, 105);
            searchbtn.Name = "searchbtn";
            searchbtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            searchbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            searchbtn.Size = new Size(55, 55);
            searchbtn.TabIndex = 17;
            searchbtn.Click += searchbtn_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Red;
            guna2CircleButton1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Location = new Point(390, 12);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(43, 48);
            guna2CircleButton1.TabIndex = 18;
            guna2CircleButton1.Text = "x";
            guna2CircleButton1.TextOffset = new Point(0, -5);
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // ChatbotForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightCyan;
            ClientSize = new Size(459, 592);
            Controls.Add(guna2CircleButton1);
            Controls.Add(searchbtn);
            Controls.Add(label1);
            Controls.Add(chatRichTextBox);
            Controls.Add(messagebox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChatbotForm";
            Text = "ChatbotForm";
            Load += ChatbotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox messagebox;
        private RichTextBox chatRichTextBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton searchbtn;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}