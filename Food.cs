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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-032\SQLEXPRESS ; Initial Catalog = eventmanagement;Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into food_tbl1 values (@foodname,@price,@quantity,@status)", con);
            //cmd.Parameters.AddWithValue("@foodId", int.Parse(foodid_txt.Text));
            cmd.Parameters.AddWithValue("@foodName", (foodname_txt.Text));
            cmd.Parameters.AddWithValue("@price", (price_txt.Text));
            cmd.Parameters.AddWithValue("@quantity", (quantity_txt.Text));
            cmd.Parameters.AddWithValue("@status", (status_txt.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void addfd_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food_tbl1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void newad_btn_Click(object sender, EventArgs e)
        {
            foodid_txt.Text =  "";
            foodname_txt.Text =  "";
            price_txt.Text =  "";
            quantity_txt.Text =  "";
            status_txt.Text =  "";
        }

        private void deletefd_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete food_tbl1 where foodid=@foodid", con);
            cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodid_txt.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void displayfd_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food_tbl1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Food_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data source = LAPTOP-032\SQLEXPRESS ; initial catalog = eventmanagement;Integrated security = true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food_tbl1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to Delete Logout?", "Conformation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Sucessfully");
                LoginPage F = new LoginPage();
                F.Show();
                this.Hide();
            }
        }

        private void updatefd_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-032\SQLEXPRESS ; Initial Catalog = eventmanagement;Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update food_tbl1 set foodname =@foodname,price= @price,quantity=@quantity, status=@status where foodid=@foodid", con);
            //cmd.Parameters.AddWithValue("@FoodId", int.Parse(foodid_txt.Text));
            cmd.Parameters.AddWithValue("@FoodName", (foodname_txt.Text));
            cmd.Parameters.AddWithValue("@Price", (price_txt.Text));
            cmd.Parameters.AddWithValue("@Quantity", (quantity_txt.Text));
            cmd.Parameters.AddWithValue("@Status", (status_txt.Text));
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foodid_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                foodname_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                price_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                quantity_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                status_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
