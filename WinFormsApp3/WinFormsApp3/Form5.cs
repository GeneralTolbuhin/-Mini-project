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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Check if the room is available
                string availabilityQuery = "SELECT availability FROM cars1 WHERE CarID = @CarID";

                SqlCommand availabilityCmd = new SqlCommand(availabilityQuery, sqlCon);
                availabilityCmd.Parameters.AddWithValue("@CarID", CarID.Text);
                string availability = availabilityCmd.ExecuteScalar().ToString().Trim();

                if (availability.Equals("free", StringComparison.OrdinalIgnoreCase))
                {
                    // Room is available, proceed with booking
                    string insertQuery = "INSERT INTO car_rental VALUES (@CarID, @gName, @pNumber, @ciDate, @coDate)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, sqlCon);

                    // Set parameters based on selected values
                    insertCmd.Parameters.AddWithValue("@CarID", CarID.Text);
                    insertCmd.Parameters.AddWithValue("@gName", name.Text);
                    insertCmd.Parameters.AddWithValue("@pNumber", phonenumber.Text);
                    insertCmd.Parameters.AddWithValue("@ciDate", checkInDate.Value);
                    insertCmd.Parameters.AddWithValue("@coDate", checkOutDate.Value);

                    insertCmd.ExecuteNonQuery();

                    // Update room availability status
                    string updateAvailabilityQuery = "UPDATE cars1 SET availability = 'taken' WHERE CarID = @CarID";
                    SqlCommand updateAvailabilityCmd = new SqlCommand(updateAvailabilityQuery, sqlCon);
                    updateAvailabilityCmd.Parameters.AddWithValue("@CarID", CarID.Text);
                    updateAvailabilityCmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Successful!");
                }
                else
                {
                    // Room is not available
                    MessageBox.Show("Sorry, the car is not available for booking.");
                }
                string username = name.Text;

                using (Form6 form6 = new Form6(username))
                {
                    form6.ShowDialog();

                }
            }
        }
    }
}

