using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoneEventManagement2
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        public bool IsEmailVaild(string email)
        {
            string pattern = "^[a-zA-z0-9+_.-]+@[a-zA-z0-9.-]+$";
            Regex r = new Regex(pattern);
            return r.IsMatch(email);

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (reguname_tb.Text.Trim() != ""&&  regftname_tb.Text.Trim() != "" &&  regltname_tb.Text.Trim() != "" && regmblnum_tb.Text.Trim() != "" &&  regspass_tb.Text.Trim() != "" && regcpass_tb.Text.Trim() != "" &&  regemail_tb.Text.Trim() != "" && regplace_tb.Text.Trim() != "")
                {
                    string emailAddress = regemail_tb.Text.Trim();
                    bool isvalid = IsEmailVaild(emailAddress);
                    if (isvalid)
                    {
                        if (regspass_tb.Text.Trim().Length >=8)
                        {
                            if (regspass_tb.Text.Trim() == regcpass_tb.Text.Trim())
                            {

                                SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
                                con.Open();
                                SqlCommand cmd = new SqlCommand("sp_register1", con);
                                cmd.CommandType= CommandType.StoredProcedure;

                                SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p1).Value = reguname_tb.Text.Trim();

                                SqlParameter p2 = new SqlParameter("@ftname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p2).Value = regftname_tb.Text.Trim();

                                SqlParameter p3 = new SqlParameter("@ltname", SqlDbType.VarChar);
                                cmd.Parameters.Add(p3).Value = regltname_tb.Text.Trim();

                                SqlParameter p4 = new SqlParameter("@mblnum", SqlDbType.VarChar);
                                cmd.Parameters.Add(p4).Value = regmblnum_tb.Text.Trim();

                                SqlParameter p5 = new SqlParameter("@spassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p5).Value = regspass_tb.Text.Trim();

                                SqlParameter p6 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                                cmd.Parameters.Add(p6).Value = regcpass_tb.Text.Trim();

                                SqlParameter p7 = new SqlParameter("@email", SqlDbType.VarChar);
                                cmd.Parameters.Add(p7).Value = regemail_tb.Text.Trim();

                                SqlParameter p8 = new SqlParameter("@place", SqlDbType.VarChar);
                                cmd.Parameters.Add(p8).Value = regplace_tb.Text.Trim();

                                int a = cmd.ExecuteNonQuery();

                                if (a>0)
                                {
                                    MessageBox.Show("Registered Successfully");

                                }
                                else
                                {
                                    MessageBox.Show("Registeration Failed");
                                    con.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Miss Matching Password");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password Must have a 8 Digits");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Email in correct format");
                    }


                }
                else
                {
                    MessageBox.Show("Fill all the Data's");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reguname_tb.Clear();
            regftname_tb.Clear();
            regltname_tb.Clear();
            regmblnum_tb.Clear();
            regspass_tb.Clear();
            regcpass_tb.Clear();
            regemail_tb.Clear();
            regplace_tb.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult check = MessageBox.Show("Are you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LoginPage f = new LoginPage();
            f.Show();
            this.Hide();
        }
    }
}

