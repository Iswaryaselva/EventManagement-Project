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
using System.Xml.Linq;

namespace OzoneEventManagement2
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        public bool IsEmailVaild(string email)
        {
            string pattern = "^[a-zA-z0-9+_.-]+@[a-zA-z0-9.-]+$";
            Regex r = new Regex(pattern);
            return r.IsMatch(email);

        }
        private void sumbit_btn_Click(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtName.Clear();
            txtEmailAddress.Clear();
            txtMessage.Clear();
            cmbGender.Items.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtName.Text.Trim() != ""&&  txtEmailAddress.Text.Trim() != "" &&  txtMessage.Text.Trim() != ""  && cmbGender.SelectedItem.ToString()  != "")
                {
                    string emailAddress = txtEmailAddress.Text.Trim();
                    bool isvalid = IsEmailVaild(emailAddress);
                    if (isvalid)
                    {
                        SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_ContactUs_tbl", con);
                        cmd.CommandType= CommandType.StoredProcedure;

                        SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = txtName.Text.Trim();

                        SqlParameter p2 = new SqlParameter("@emailaddress", SqlDbType.VarChar);
                        cmd.Parameters.Add(p2).Value = txtEmailAddress.Text.Trim();

                        SqlParameter p3 = new SqlParameter("@message", SqlDbType.VarChar);
                        cmd.Parameters.Add(p3).Value = txtMessage.Text.Trim();

                        SqlParameter p4 = new SqlParameter("@gender", SqlDbType.VarChar);
                        cmd.Parameters.Add(p4).Value = cmbGender.SelectedItem.ToString();

                        int a = cmd.ExecuteNonQuery();

                        if (a>0)
                        {
                            MessageBox.Show("Submit Successfully");

                        }
                        else
                        {
                            MessageBox.Show("Failed");
                            con.Close();
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
    }
}
