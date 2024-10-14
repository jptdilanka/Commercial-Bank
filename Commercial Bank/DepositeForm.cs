using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Commercial_Bank
{
    public partial class DepositeForm : Form
    {
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\OneDrive\Documents\Commercial Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public DepositeForm()
        {
            InitializeComponent();
        }

        private void DepositeForm_Load(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            // Clear previous details
            ClearLabels();
            detailspanel.Visible = false; // Hide details panel initially
            MessageLabel.Visible = false; // Hide message label

            string accountNo = AccountNoTextBox.Text.Trim();

            if (string.IsNullOrEmpty(accountNo))
            {
                ShowMessage("Please enter an account number.", Color.Red);
                return;
            }

            try
            {
                Con.Open();
                string query = "SELECT MName, MPhone, MAge, MGen, NIC, AccType, Email FROM MemberTbl WHERE AccountNo = @AccountNo";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate the labels with the member details
                    namelabel.Text = reader["MName"].ToString();
                    pno.Text = reader["MPhone"].ToString();
                    niclabel.Text = reader["NIC"].ToString();
                    acclabel.Text = reader["AccType"].ToString();

                    // Show the details panel
                    detailspanel.Visible = true;
                }
                else
                {
                    ShowMessage("Account not found.", Color.Red);
                }

                reader.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, Color.Red);
                Con.Close();
            }
        }

        private void ClearLabels()
        {
            namelabel.Text = "";
            pno.Text = "";
            acclabel.Text = "";
            niclabel.Text = "";
        }

        private void ShowMessage(string message, Color color)
        {
            MessageLabel.Text = message;
            MessageLabel.ForeColor = color;
            MessageLabel.Visible = true; // Show the message label
        }

        private void depositebtn_Click(object sender, EventArgs e)
        {
            string depositAmountText = depositetxtbox.Text.Trim();

            // Check if the deposit amount is valid
            if (string.IsNullOrEmpty(depositAmountText) ||
                !decimal.TryParse(depositAmountText, out decimal depositAmount) ||
                depositAmount <= 0)
            {
                ShowMessage("Please enter a valid deposit amount.", Color.Red);
                return;
            }

            string accountNo = AccountNoTextBox.Text.Trim(); // Get the account number from the textbox

            if (string.IsNullOrEmpty(accountNo))
            {
                ShowMessage("Please enter an account number.", Color.Red);
                return;
            }

            try
            {
                Con.Open();

                // Use a single query to get MId, MName, and Email from MemberTbl
                string query = "SELECT MId, MName, Email FROM MemberTbl WHERE AccountNo = @AccountNo";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);

                SqlDataReader reader = cmd.ExecuteReader();

                // Read member details
                if (reader.Read())
                {
                    int memberId = reader.GetInt32(0); // Get the MId of the member
                    string memberName = reader["MName"].ToString(); // Get member name
                    string memberEmail = reader["Email"].ToString(); // Get member email
                    reader.Close(); // Close reader before executing next command

                    // Now check if the account exists in the Accounts table
                    string balanceQuery = "SELECT Balance FROM Accounts WHERE MId = @MId";
                    SqlCommand balanceCmd = new SqlCommand(balanceQuery, Con);
                    balanceCmd.Parameters.AddWithValue("@MId", memberId);

                    // Execute reader to check existing balance
                    SqlDataReader balanceReader = balanceCmd.ExecuteReader();

                    if (balanceReader.Read())
                    {
                        // Account exists, update the balance
                        decimal existingBalance = balanceReader.GetDecimal(0);
                        decimal newBalance = existingBalance + depositAmount;

                        balanceReader.Close(); // Close reader before executing update command

                        // Update the balance in the Accounts table
                        string updateQuery = "UPDATE Accounts SET Balance = @Balance, Deposit = Deposit + @Deposit WHERE MId = @MId";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                        updateCmd.Parameters.AddWithValue("@Balance", newBalance);
                        updateCmd.Parameters.AddWithValue("@Deposit", depositAmount);
                        updateCmd.Parameters.AddWithValue("@MId", memberId);

                        updateCmd.ExecuteNonQuery();

                        ShowMessage("Deposit successful! New Balance: " + newBalance.ToString("C"), Color.Green);

                        // Send email notification
                        SendEmail(memberName, accountNo, newBalance, depositAmount, memberEmail);
                    }
                    else
                    {
                        // Account does not exist, insert new account record
                        balanceReader.Close(); // Close reader before executing insert command

                        string insertQuery = "INSERT INTO Accounts (MId, Balance, Deposit) VALUES (@MId, @Balance, @Deposit)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, Con);
                        insertCmd.Parameters.AddWithValue("@MId", memberId);
                        insertCmd.Parameters.AddWithValue("@Balance", depositAmount); // Set initial balance to the deposit amount
                        insertCmd.Parameters.AddWithValue("@Deposit", depositAmount); // Log the deposit amount

                        insertCmd.ExecuteNonQuery();

                        ShowMessage("New account created and deposit successful! Amount: " + depositAmount.ToString("C"), Color.Green);

                        // Send email notification
                        SendEmail(memberName, accountNo, depositAmount, depositAmount, memberEmail);
                    }
                }
                else
                {
                    ShowMessage("Account not found.", Color.Red);
                }
            }
            catch (Exception ex)
            {
                ShowMessage("An error occurred: " + ex.Message, Color.Red);
            }
            finally
            {
                // Always close the connection in the finally block
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void SendEmail(string name, string accountNumber, decimal newBalance, decimal depositAmount, string recipientEmail)
        {
            try
            {
                // Setup SMTP client
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587; // or the port number your SMTP server uses
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("anushmanuja@gmail.com", "bcdptzzzuedsylvd"); // Update with your email and app password

                // Create email message
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("your_email@gmail.com");
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = "Deposit Confirmation";
                mailMessage.Body = $"Dear {name},\n\n" +
                                   "Your deposit was successful!\n\n" +
                                   $"**Account Holder Name**: {name}\n" +
                                   $"**Account Number**: {accountNumber}\n" +
                                   $"**Deposit Amount**: {depositAmount.ToString("C")}\n" +
                                   $"**Current Balance**: {newBalance.ToString("C")}\n\n" +
                                   "Thank you for banking with us!\n\n" +
                                   "Best regards,\n" +
                                   "**Commercial Bank Team**";

                client.Send(mailMessage);
                MessageBox.Show("Deposit confirmation email sent to the user.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
