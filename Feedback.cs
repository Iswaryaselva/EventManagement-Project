using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OzoneEventManagement2
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void sumbit_btn_Click(object sender, EventArgs e)
        {
            

            string name = txtname.Text;
            string email = txtemail.Text;
            string feedback = txtfeedback.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // For demo purposes, just show the feedback in a message box
            MessageBox.Show($"Name: {name}\nEmail: {email}\nFeedback: {feedback}", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear the fields after submission
            txtname.Clear();
            txtemail.Clear();
            txtfeedback.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
