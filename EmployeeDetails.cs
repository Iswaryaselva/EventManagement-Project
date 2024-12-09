using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzoneEventManagement2
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_emp_details", con);


            cmd.CommandType= CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = textBox1_tb.Text.Trim();

            SqlParameter p2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = textBox2_tb.Text.Trim();

            SqlParameter p3 = new SqlParameter("@emp_salary", SqlDbType.VarChar);
            cmd.Parameters.Add(p3).Value = textBox3_tb.Text.Trim();

            SqlParameter p4 = new SqlParameter("@emp_dep", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = comboBox3.SelectedItem.ToString();

            SqlParameter p5 = new SqlParameter("@emp_role", SqlDbType.VarChar);
            cmd.Parameters.Add(p5).Value = comboBox4.SelectedItem.ToString();

            int a = cmd.ExecuteNonQuery();

            if (a>0)
            {
                MessageBox.Show("Employee Details Added");

            }
            else
            {
                MessageBox.Show("!!! Failed!!!!");
                con.Close();
            }
        }

        private void fetch_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch2", con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate text boxes and combo boxes
                if (string.IsNullOrWhiteSpace(textBox1_tb.Text))
                {
                    MessageBox.Show("Please enter a value for Employee ID.");
                    textBox1_tb.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2_tb.Text))
                {
                    MessageBox.Show("Please enter a value for Employee Name.");
                    textBox2_tb.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox3_tb.Text) || !decimal.TryParse(textBox3_tb.Text.Trim(), out decimal salary))
                {
                    MessageBox.Show("Please enter a valid value for Employee Salary.");
                    textBox3_tb.Focus();
                    return;
                }

                if (comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Department.");
                    comboBox3.Focus();
                    return;
                }

                if (comboBox4.SelectedItem == null)
                {
                    MessageBox.Show("Please select a Role.");
                    comboBox4.Focus();
                    return;
                }

                // Retrieve selected values
                string empId = textBox1_tb.Text.Trim();
                string empName = textBox2_tb.Text.Trim();
                decimal empSalary = salary;
                string empDept = comboBox3.SelectedItem.ToString();
                string empRole = comboBox4.SelectedItem.ToString();

                // Create and open SQL connection
                using (SqlConnection con = new SqlConnection(@"Data source=LAPTOP-032\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=true"))
                {
                    con.Open();

                    // Create SQL command and set its properties
                    using (SqlCommand cmd = new SqlCommand("sp_update3", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@emp_id", empId);
                        cmd.Parameters.AddWithValue("@emp_name", empName);
                        cmd.Parameters.AddWithValue("@emp_salary", empSalary);
                        cmd.Parameters.AddWithValue("@emp_dep", empDept);
                        cmd.Parameters.AddWithValue("@emp_role", empRole);

                        // Execute the stored procedure
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Provide feedback to the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data update successful.");
                        }
                        else
                        {
                            MessageBox.Show("Data update failed. Please check the Employee ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void Print_btn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap B = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(B, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(B, 120, 120);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Delete Employee?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value =textBox1_tb.Text;

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Deleted Sucessfully");
                }
                con.Close();

            }
        }

            private void Search_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search2", con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value =textBox4_tb.Text;
            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}