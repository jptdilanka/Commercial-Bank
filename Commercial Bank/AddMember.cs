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

namespace Commercial_Bank
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\L e n o v o\source\repos\BPERP\Commercial Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30");
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AccNoTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!ValidateNIC(AccNoTb.Text))
            {

            }

            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTbl values('" + NameTb.Text + "','" + PhoneTb.Text + "'," + AgeTb.Text + ",'" + GenderCb.SelectedItem.ToString() + "'," + AccNoTb.Text + ",'" + AccTypeCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    AgeTb.Text = "";
                    GenderCb.Text = "";
                    AccNoTb.Text = "";
                    AccTypeCb.Text = "";
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
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        
    }
}
