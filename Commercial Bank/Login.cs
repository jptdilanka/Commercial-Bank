namespace Commercial_Bank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "123")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else if (UidTb.Text == "Member" && PassTb.Text == "12345")
            {
                AddMember addmember = new AddMember();
                addmember.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong ID or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
