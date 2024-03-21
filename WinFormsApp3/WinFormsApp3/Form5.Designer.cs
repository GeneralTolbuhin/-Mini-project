namespace WinFormsApp3
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkInDate = new DateTimePicker();
            checkOutDate = new DateTimePicker();
            name = new TextBox();
            phonenumber = new TextBox();
            CarID = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkInDate
            // 
            checkInDate.Location = new Point(80, 169);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(200, 23);
            checkInDate.TabIndex = 0;
            // 
            // checkOutDate
            // 
            checkOutDate.Location = new Point(461, 169);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(200, 23);
            checkOutDate.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(80, 96);
            name.Name = "name";
            name.PlaceholderText = "Username";
            name.Size = new Size(200, 23);
            name.TabIndex = 2;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(461, 96);
            phonenumber.Name = "phonenumber";
            phonenumber.PlaceholderText = "Phone Number";
            phonenumber.Size = new Size(200, 23);
            phonenumber.TabIndex = 3;
            // 
            // CarID
            // 
            CarID.FormattingEnabled = true;
            CarID.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130" });
            CarID.Location = new Point(311, 246);
            CarID.Name = "CarID";
            CarID.Size = new Size(121, 23);
            CarID.TabIndex = 4;
            CarID.Text = "Car ID";
            // 
            // button1
            // 
            button1.Location = new Point(333, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Rent";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CarID);
            Controls.Add(phonenumber);
            Controls.Add(name);
            Controls.Add(checkOutDate);
            Controls.Add(checkInDate);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker checkInDate;
        private DateTimePicker checkOutDate;
        private TextBox name;
        private TextBox phonenumber;
        private ComboBox CarID;
        private Button button1;
    }
}