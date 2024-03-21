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

namespace WinFormsApp3
{
    public partial class Form7 : Form
    {
        private readonly string username;
        private readonly int selectedCarID;

        public Form7(string username, int selectedCarID)
        {
            InitializeComponent();
            this.username = username;
            this.selectedCarID = selectedCarID;

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBoxFields.Items.AddRange(new string[] { "CarID", "gName", "pNumber", "ciDate", "coDate" });
            comboBoxFields.SelectedIndex = 0; // Set the default selection
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    // Construct the SQL command dynamically based on the selected field
                    string fieldName = comboBoxFields.SelectedItem.ToString();
                    string updateQuery = $"UPDATE car_rental SET {fieldName} = @NewValue WHERE CarID = @CarID";

                    SqlCommand cmd = new SqlCommand(updateQuery, sqlCon);
                    cmd.Parameters.AddWithValue("@NewValue", textBoxNewValue.Text);
                    cmd.Parameters.AddWithValue("@CarID", selectedCarID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Set DialogResult to OK to indicate success
                    this.Close(); // Close Form7
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
