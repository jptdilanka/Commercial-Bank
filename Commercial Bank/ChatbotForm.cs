using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Bank
{
    public partial class ChatbotForm : Form
    {
        public ChatbotForm()
        {
            InitializeComponent();
        }

        private void messagebox_KeyDown(object sender, KeyEventArgs e)
        {
            // Allow pressing Enter to send the message
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // Suppress the "ding" sound when pressing Enter
            }
        }
        private void SendMessage()
        {
            string userMessage = messagebox.Text.Trim();
            if (!string.IsNullOrEmpty(userMessage))
            {
                // Display user message
                chatRichTextBox.AppendText("You: " + userMessage + "\n");

                // Get bot response
                string botResponse = GetBotResponse(userMessage);

                // Display bot response
                chatRichTextBox.AppendText("Bot: " + botResponse + "\n");

                // Clear the input box
                messagebox.Clear();
            }
        }

        private string GetBotResponse(string userMessage)
        {
            // Simple chatbot logic with predefined responses
            userMessage = userMessage.ToLower(); // Convert to lowercase for easier comparison

            if (userMessage.Contains("hello"))
            {
                return "Hello! How can I assist you today?";
            }
            else if (userMessage.Contains("how are you"))
            {
                return "I'm just a bot, but thanks for asking! How can I help you?";
            }
            else if (userMessage.Contains("time"))
            {
                return "Current time is " + DateTime.Now.ToString("HH:mm:ss");
            }
            else if (userMessage.Contains("bye"))
            {
                return "Goodbye! Have a great day!";
            }
            else
            {
                return "I'm sorry, I don't understand that. Can you rephrase?";
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AddMember viewmember = new AddMember();
            viewmember.Show();
            this.Hide();
        }

        private void ChatbotForm_Load(object sender, EventArgs e)
        {

        }
    }
}
