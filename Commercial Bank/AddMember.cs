using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Commercial_Bank
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\OneDrive\Documents\Commercial Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any required field is empty
            if (NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || emailtextbox.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!ValidateNIC(AccNoTb.Text))  // Validate NIC format
            {
                MessageBox.Show("Invalid NIC number. Please check the NIC and try again.");
            }
            else
            {
                try
                {
                    // Generate account number, username, and password
                    string generatedAccountNumber = GenerateAccountNumber();
                    string generatedUsername = GenerateUsername(NameTb.Text);
                    string generatedPassword = GeneratePassword(10);

                    // Open database connection
                    Con.Open();

                    // Insert new member details, including auto-generated username and password
                    string query = "INSERT INTO MemberTbl (MName, MPhone, MAge, MGen, NIC, AccType, email, AccountNo, Username, Password) " +
                                   "VALUES('" + NameTb.Text + "','" + PhoneTb.Text + "'," + AgeTb.Text + ",'" + GenderCb.SelectedItem.ToString() +
                                   "','" + AccNoTb.Text + "','" + AccTypeCb.SelectedItem.ToString() + "','" + emailtextbox.Text + "','" +
                                   generatedAccountNumber + "','" + generatedUsername + "','" + generatedPassword + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");

                    // Send email with account details, username, and password
                    SendEmail(NameTb.Text, generatedAccountNumber, generatedUsername, generatedPassword);

                    // Clear fields
                    ClearFields();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

        private string GenerateUsername(string name)
        {
            // Take only the first part of the name (before any spaces)
            string firstName = name.Split(' ')[0];

            Random random = new Random();
            string randomPart = random.Next(100, 999).ToString();

            return firstName + randomPart;
        }


        private string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendEmail(string name, string accountNumber, string accountType)
        {
            try
            {
                // Setup SMTP client
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587; // or the port number your SMTP server uses
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("anushmanuja@gmail.com", "bcdptzzzuedsylvd");

                // Create email message
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("anushmanuja@gmail.com");

                // Use emailtextbox.Text for recipient email
                mailMessage.To.Add(emailtextbox.Text);
                mailMessage.Subject = "Welcome to Commercial Bank - Your Account is Now Active!";
                mailMessage.Body = $"Dear {name},\n\n" +
                                   "Welcome to Commercial Bank! We are thrilled to have you join us as a valued member. Below are your account credentials and details:\n\n" +
                                   "-----------------------------------------------------\n" +
                                   $"Account Holder Name: {name}\n" +
                                   $"Account Number: {accountNumber}\n" +
                                   $"Account Type: {accountType}\n" +
                                   "-----------------------------------------------------\n\n" +
                                   "For your convenience, you can now access your account online through our secure banking portal.\n\n" +
                                   "If you have any questions or need assistance, feel free to contact our support team. We look forward to serving you and ensuring your financial success!\n\n" +
                                   "Thank you for choosing Commercial Bank.\n\n" +
                                   "Warm regards,\n" +
                                   "Commercial Bank Team";

                client.Send(mailMessage);
                MessageBox.Show("Account details have been sent to the user's email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }

        private bool ValidateNIC(string nic)
        {

            if (nic.Length >= 4 && int.TryParse(nic.Substring(0, 4), out int year))
            {
                if (year >= 2000 && year <= 3000)
                {
                    // Check if NIC has 12 digits
                    if (nic.Length == 12 && nic.All(char.IsDigit))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid NIC number.");
                        return false;
                    }
                }
            }

            // Check for NIC with 9 digits ending with "v"
            if (nic.Length == 10 && nic.Substring(0, 9).All(char.IsDigit) && nic.EndsWith("v", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                MessageBox.Show("NIC number must have 9 digits followed by 'v' for older format.");
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            GenderCb.Text = "";
            AccNoTb.Text = "";
            AccTypeCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            GenderCb.Text = "";
            AccNoTb.Text = "";
            AccTypeCb.Text = "";
            emailtextbox.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private string GenerateAccountNumber()
        {
            Random random = new Random();
            string accountNumber = random.Next(100000, 999999).ToString() + random.Next(100000, 999999).ToString();
            return accountNumber;
        }

    }
}


    

