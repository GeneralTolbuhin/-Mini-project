using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;


namespace WinFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Set default values for ComboBoxes when the form is loaded
            cartype.SelectedIndex = -1;
            availability.SelectedIndex = -1;
            status.SelectedIndex = -1;
            colours.SelectedIndex = -1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM cars1 WHERE 1 = 1";

                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (status.SelectedItem != null)
                    conditions.Add("status = @status");

                if (cartype.SelectedItem != null)
                    conditions.Add("cartype = @cartype");

                if (availability.SelectedItem != null)
                    conditions.Add("availability = @availability");

                if (colours.SelectedItem != null)
                    conditions.Add("colours = @colours");

                // Combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values
                if (status.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@status", status.SelectedItem.ToString());


                if (cartype.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@cartype", cartype.SelectedItem.ToString());


                if (availability.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@availability", availability.SelectedItem.ToString());


                if (colours.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@colours", colours.SelectedItem.ToString());


                // Use SqlDataAdapter to fetch data and populate dataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cartype.SelectedIndex = 0;
            availability.SelectedIndex = 0;
            status.SelectedIndex = 0;
            colours.SelectedIndex = 0;
        }

        private void rentacar_Click(object sender, EventArgs e)
        {
            using (Form5 userInputForm = new Form5())
            {
                // Display the form as a dialog
                userInputForm.ShowDialog();
            }
        }
    }
}
