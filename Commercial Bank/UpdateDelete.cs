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

namespace Commercial_Bank
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            dgv.AllowDrop = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.BackgroundColor = System.Drawing.Color.White;
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellStyle.ForeColor = System.Drawing.Color.Black;
            cellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            cellStyle.WrapMode = DataGridViewTriState.True;
            dgv.DefaultCellStyle = cellStyle;
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.SystemColors.Window;
            headerStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerStyle.ForeColor = System.Drawing.Color.Black;
            headerStyle.SelectionBackColor = System.Drawing.Color.White;
            headerStyle.SelectionForeColor = System.Drawing.Color.Black;
            headerStyle.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = headerStyle;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 0;
            dgv.TabStop = false;
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\OneDrive\Documents\New folder (2)\Commercial-Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            dgv.AutoGenerateColumns = false;  // Disable auto-generation of columns

            Con.Open();
            string query = "Select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];

            // Manually create and add columns with meaningful headers
            dgv.Columns.Clear();  // Clear any existing columns

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "MId";  // Bind to the database column name
            dgv.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "MName";
            dgv.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "Phone";
            phoneColumn.DataPropertyName = "MPhone";
            dgv.Columns.Add(phoneColumn);

            DataGridViewTextBoxColumn ageColumn = new DataGridViewTextBoxColumn();
            ageColumn.HeaderText = "Age";
            ageColumn.DataPropertyName = "MAge";
            dgv.Columns.Add(ageColumn);

            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.HeaderText = "Gender";
            genderColumn.DataPropertyName = "MGen";
            dgv.Columns.Add(genderColumn);

            DataGridViewTextBoxColumn accNoColumn = new DataGridViewTextBoxColumn();
            accNoColumn.HeaderText = "Account No";
            accNoColumn.DataPropertyName = "AccountNo";
            dgv.Columns.Add(accNoColumn);

            DataGridViewTextBoxColumn accTypeColumn = new DataGridViewTextBoxColumn();
            accTypeColumn.HeaderText = "Account Type";
            accTypeColumn.DataPropertyName = "AccType";
            dgv.Columns.Add(accTypeColumn);

            Con.Close();
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            AgeTb.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            GenderCb.Text = dgv.SelectedRows[0].Cells[4].Value.ToString();
            AccNoTb.Text = dgv.SelectedRows[0].Cells[5].Value.ToString();
            AccTypeCb.Text = dgv.SelectedRows[0].Cells[6].Value.ToString();

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

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Member To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();

                    // Start a transaction
                    SqlTransaction transaction = Con.BeginTransaction();

                    // Delete related accounts
                    string deleteAccountsQuery = "DELETE FROM Accounts WHERE MId = @MId";
                    SqlCommand deleteAccountsCmd = new SqlCommand(deleteAccountsQuery, Con, transaction);
                    deleteAccountsCmd.Parameters.AddWithValue("@MId", key);
                    deleteAccountsCmd.ExecuteNonQuery();

                    // Delete the member
                    string deleteMemberQuery = "DELETE FROM MemberTbl WHERE MId = @MId";
                    SqlCommand deleteMemberCmd = new SqlCommand(deleteMemberQuery, Con, transaction);
                    deleteMemberCmd.Parameters.AddWithValue("@MId", key);
                    deleteMemberCmd.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();

                    MessageBox.Show("Member and related accounts deleted successfully.");

                    Con.Close();
                    populate();

                    // Clear the form fields
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    AgeTb.Text = "";
                    GenderCb.SelectedIndex = -1;
                    AccNoTb.Text = "";
                    AccTypeCb.SelectedIndex = -1;

                    dgv.ClearSelection();
                    key = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text=="" || PhoneTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || AccNoTb.Text == "" || AccTypeCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string querry = "update MemberTbl set MName='" + NameTb.Text +
               "', MPhone='" + PhoneTb.Text +
               "', MAge='" + AgeTb.Text +
               "', MGen='" + GenderCb.Text +
               "', AccountNo='" + AccNoTb.Text +
               "', AccType='" + AccTypeCb.Text +
               "' where MId=" + key + ";";

                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
