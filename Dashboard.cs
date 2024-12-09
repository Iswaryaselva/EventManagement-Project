using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OzoneEventManagement2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void fetch_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EmployeeDetails emdetails  = new EmployeeDetails();
            emdetails.Show();

        }

        private void Eventmange_btn_Click(object sender, EventArgs e)
        {
            EventManagement evntmanage = new EventManagement();
            evntmanage.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EmpDashboard empdash = new EmpDashboard();
            empdash.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();  
            about.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Contact cont = new Contact();
            cont.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Feedback feedbk = new Feedback();   
            feedbk.Show();
        }
    }
}
