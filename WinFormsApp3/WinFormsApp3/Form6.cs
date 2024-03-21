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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp3
{


    public partial class Form6 : Form
    {
        private readonly string username;

        public Form6(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM car_rental WHERE gName = @gName", sqlCon);
                    cmd.Parameters.AddWithValue("@gName", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading rented cars: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rented car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
                        {
                            sqlCon.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM car_rental WHERE CarID = @CarID", sqlCon);
                            cmd.Parameters.AddWithValue("@CarID", dataGridView1.SelectedRows[0].Cells["CarID"].Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Rented car deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting rented car: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a rented car to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // You can implement your edit logic here
                // For example, open another form for editing the selected rented car
                MessageBox.Show("Implement your edit logic here.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a rented car to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
