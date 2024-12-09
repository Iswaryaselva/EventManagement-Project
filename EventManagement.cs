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
    public partial class EventManagement : Form
    {
        public EventManagement()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_eventdetails", con);


            cmd.CommandType= CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter("@event_name", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = eventname_txt.Text.Trim();

            SqlParameter p2 = new SqlParameter("@event_type", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = comboBox3.SelectedItem.ToString();

            SqlParameter p3 = new SqlParameter("@emp_id ", SqlDbType.Int);
            cmd.Parameters.Add(p3).Value = employeeid_txt.Text.Trim();

            SqlParameter p4 = new SqlParameter("@emp_code ", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = comboBox4.SelectedItem.ToString();

            SqlParameter p5 = new SqlParameter("@event_details", SqlDbType.VarChar);
            cmd.Parameters.Add(p5).Value = eventdetails_txt.Text.Trim();

            SqlParameter p6 = new SqlParameter("@event_date", SqlDbType.DateTime);
            cmd.Parameters.Add(p6).Value = dateTimePicker1.Value.ToString();


            int a = cmd.ExecuteNonQuery();

            if (a>0)
            {
                MessageBox.Show("Event details Added");

            }
            else
            {
                MessageBox.Show("!!! Failed!!!!");
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-032\SQLEXPRESS ; Initial Catalog = eventmanagement;Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into eventdetails_tbl values (@event_name,@event_type,@event_type,@emp_code,@event_details,@event_date)", con);
            //cmd.Parameters.AddWithValue("@emp_id", int.Parse(employeeid_txt.Text));
            cmd.Parameters.AddWithValue("@event_name", (eventname_txt.Text));
            cmd.Parameters.AddWithValue("@event_type", (comboBox3.SelectedItem));
            cmd.Parameters.AddWithValue("@emp_code", (comboBox4.SelectedItem));
            cmd.Parameters.AddWithValue("@event_details", (eventdetails_txt.Text));
            cmd.Parameters.AddWithValue("@event_date", (dateTimePicker1.Value));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            // Define the connection string
            string connectionString = @"Data Source=LAPTOP-032\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=True";

            // Open the connection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Define the SQL command for updating
                string query = "UPDATE eventdetails_tbl " +
                               "SET event_name = @event_name, event_type = @event_type, emp_code = @emp_code, event_details = @event_details, event_date = @event_date " +
                               "WHERE emp_id = @emp_id"; // Assumes emp_id is the unique identifier for the record

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters with values
                    cmd.Parameters.AddWithValue("@event_name", eventname_txt.Text);
                    cmd.Parameters.AddWithValue("@event_type", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@emp_code", comboBox4.Text); // Ensure this matches your database schema
                    cmd.Parameters.AddWithValue("@event_details", eventdetails_txt.Text);
                    cmd.Parameters.AddWithValue("@event_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@emp_id", int.Parse(employeeid_txt.Text)); // Assuming employeeid_txt is a TextBox for integer input

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Notify the user
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Modified Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found with the specified ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Define the connection string
            string connectionString = @"Data Source=LAPTOP-032\SQLEXPRESS;Initial Catalog=eventmanagement;Integrated Security=True";

            try
            {
                // Open the connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command for deleting
                    string query = "DELETE FROM eventdetails_tbl WHERE emp_id = @emp_id"; // Assumes emp_id is the unique identifier

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameter with value
                        cmd.Parameters.AddWithValue("@emp_id", int.Parse(employeeid_txt.Text)); // Assuming employeeid_txt is a TextBox for integer input

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Notify the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No Record Found with the specified ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exception
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_list1", con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlDataAdapter SD = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            SD.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
