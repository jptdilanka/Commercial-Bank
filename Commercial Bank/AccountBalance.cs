using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Commercial_Bank
{
    public partial class AccountBalance : Form
    {
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\OneDrive\Documents\New folder (2)\Commercial-Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30");
        public AccountBalance()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string accountNo = AccountNoTextBox.Text.Trim(); // Replace with your actual TextBox name

            if (string.IsNullOrEmpty(accountNo))
            {
                ShowMessage("Please enter an account number.", Color.Red);
                return;
            }

            try
            {
                Con.Open();

                // Query to get member details based on account number
                string query = "SELECT MName, NIC, AccType, MPhone, A.Balance FROM MemberTbl M INNER JOIN Accounts A ON M.MId = A.MId WHERE M.AccountNo = @AccountNo";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccountNo", accountNo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate the labels with account details
                    namelabel.Text = reader["MName"].ToString(); // Replace with your actual Label names
                    niclabel.Text = reader["NIC"].ToString();
                    acclabel.Text = reader["AccType"].ToString();
                    pno.Text = reader["MPhone"].ToString();
                    amount.Text = Convert.ToDecimal(reader["Balance"]).ToString("C");

                    // Make details panel visible
                    detailspanel.Visible = true;
                    MessageLabel.Text = "";
                }
                else
                {
                    ShowMessage("Account not found.", Color.Red);
                    detailspanel.Visible = false;
                }

                reader.Close();
                Con.Close();
            }
            catch (Exception ex)
            {
                ShowMessage("An error occurred: " + ex.Message, Color.Red);
                Con.Close();
            }
        }

        private void ShowMessage(string message, Color color)
        {
            MessageLabel.Text = message; // Replace with your actual Message Label name
            MessageLabel.ForeColor = color;
            MessageLabel.Visible = true; // Show the message label
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void AccountBalance_Load(object sender, EventArgs e)
        {

        }
    }
}
