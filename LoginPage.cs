using Microsoft.Win32;
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

namespace OzoneEventManagement2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (loguname_tb.Text.Trim() =="" || lgpass_tb.Text.Trim() =="")
                {
                    MessageBox.Show("Fill all the Data's");
                }
                else if ((loguname_tb.Text.Trim() =="Admin" || lgpass_tb.Text.Trim() =="12345"))

                {
                    MessageBox.Show("Welcome Back Admin");
                    Dashboard D = new Dashboard();
                    D.Show();
                    this.Hide();
                }
                else

                {

                    SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType= CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = loguname_tb.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@cpassword", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = lgpass_tb.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show("Welcome Back" + loguname_tb.Text);
                        EmpDashboard ED = new EmpDashboard();
                        ED.Show();
                        this.Hide();
                    }
                    else if (loguname_tb.Text.Trim() =="" || lgpass_tb.Text.Trim() =="")
                    {
                        MessageBox.Show("Fill all the Data's");
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");

                    }
                    con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loguname_tb.Clear();
            lgpass_tb.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lgpass_tb.PasswordChar = checkBox1.Checked? '\0' : '*';
            
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword Fp = new ForgetPassword();
            Fp.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage R = new RegisterPage();
            R.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void loguname_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
