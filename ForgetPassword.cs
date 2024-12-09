using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoneEventManagement2
{
    public partial class ForgetPassword : Form
    {
        string randomcode;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(randomcode ==(txtVerify.Text).ToString())
            {
                MessageBox.Show("Verified Success");
                ResetPassword resetpass = new ResetPassword();
                this.Hide();
                resetpass.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody,to;
            Random rand = new Random();
            randomcode= (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "iswarya420ice@gmail.com";
            pass = "hgya eiog xiar yhde";
            messageBody = "your reset code is "+ randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";
            SmtpClient smtp = new SmtpClient("stmp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port= 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully ");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
