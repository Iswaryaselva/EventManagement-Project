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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OzoneEventManagement2
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_updatepassword", con);


                cmd.CommandType= CommandType.StoredProcedure;

                SqlParameter p1 = new SqlParameter(" @username", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = username_txt.Text.Trim();

                SqlParameter p2 = new SqlParameter(" @setnewpassword", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = setpass_txt.Text.Trim();

                SqlParameter p3 = new SqlParameter("@conformnewpassword", SqlDbType.VarChar);
                cmd.Parameters.Add(p3).Value = conformpass_txt.Text.Trim();

               

                int a = cmd.ExecuteNonQuery();

                if (a>0)
                {
                    MessageBox.Show("NewPassworrd Update success");

                }
                else
                {
                    MessageBox.Show("!!! Updation Failed!!!!");
                    con.Close();
                }

            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setpass_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
