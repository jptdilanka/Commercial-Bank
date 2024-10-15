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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDelete updatedelete = new UpdateDelete();
            updatedelete.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountBalance transaction = new AccountBalance();
            transaction.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewMember viewmember = new ViewMember();
            viewmember.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            profilepanel.Visible = false;
        }


        private void depositebtn_Click(object sender, EventArgs e)
        {
            DepositeForm viewmember = new DepositeForm();
            viewmember.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login viewmember = new Login();
            viewmember.Show();
            this.Hide();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            profilepanel.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
