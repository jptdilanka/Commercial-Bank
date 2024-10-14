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
    public partial class ViewMember : Form
    {
        public ViewMember()
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
        private void populateview()
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


            DataGridViewTextBoxColumn usernameColumn = new DataGridViewTextBoxColumn();
            usernameColumn.HeaderText = "User Name";
            usernameColumn.DataPropertyName = "username";
            dgv.Columns.Add(usernameColumn);

            DataGridViewTextBoxColumn password = new DataGridViewTextBoxColumn();
            password.HeaderText = "Password";
            password.DataPropertyName = "Password";
            dgv.Columns.Add(password);

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
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\pc\OneDrive\Documents\Commercial Bank\source\BankDataBase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void populate()
        {
            Con.Open();
            string query = "Select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMember_Load(object sender, EventArgs e)
        {
            populateview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        private void filterByName()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM MemberTbl WHERE MName = @MemberName";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.Parameters.AddWithValue("@MemberName", SearchMemberTb.Text);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            finally
            {
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        
    }
}
