using System;  // Importing the System namespace
using System.Collections.Generic;  // Importing namespaces for various functionalities
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp3.authenticate;  // Importing static members from the authenticate class
using static WinFormsApp3.imageUploader;  // Importing static members from the imageUploader class
using WinFormsApp3;  // Importing the entire WinFormsDemo namespace
using System.Diagnostics;



namespace WinFormsApp3
{
    // Declaration of a partial class named Form5, which inherits from Form
    public partial class Form3 : Form
    {

        private User authenticatedUser;  // Declaration of a private variable to store authenticated user information

        // Constructor for Form5, taking a User object as a parameter
        public Form3(User user)
        {
            InitializeComponent();  // Initializing the components of the form

            authenticatedUser = user; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            hello.Text = $"Welcome, {authenticatedUser.username}!";  // Setting the text of a label
            // Displaying the user's image on the form if available
            if (user.image != null && user.image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        // Event handler for the click event of the upload button
        private void uploadBtn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();  // Creating an OpenFileDialog instance

            // Setting the filter for the file dialog to allow only specific image file types
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            // Checking if the user selected a file and clicked the OK button
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;  // Getting the path of the selected image
                    Image selectedImage = Image.FromFile(selectedImagePath);  // Creating an Image object from the selected file

                    byte[] imageData = ImageToByteArray(selectedImage);  // Converting the image to a byte array

                    // Updating the user's image in the database
                    UploadImage(authenticatedUser.username, imageData);

                    // Displaying the uploaded image on the form
                    pictureBox1.Image = selectedImage;

                    // Hiding the upload button since the user now has an image
                    uploadBtn.Hide();
                }
                catch (Exception ex)
                {
                    // Displaying an error message if an exception occurs during image upload
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentacar_Click_1(object sender, EventArgs e)
        {
            Form4 rentCarForm = new Form4();
            rentCarForm.Show();
        }
    }
}