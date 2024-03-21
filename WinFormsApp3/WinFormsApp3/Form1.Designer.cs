namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            password = new TextBox();
            username = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            email = new TextBox();
            panel6 = new Panel();
            uppercase = new Label();
            number = new Label();
            len = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(52, 430);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(213, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "I agree to the Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(61, 469);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            password.Location = new Point(52, 254);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(217, 36);
            password.TabIndex = 2;
            password.TextAlign = HorizontalAlignment.Center;
            password.Validating += password_Validating;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username.Location = new Point(52, 196);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(217, 36);
            username.TabIndex = 3;
            username.TextAlign = HorizontalAlignment.Center;
            username.Validating += username_Validating;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(52, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 10);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(52, 296);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 10);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.MenuHighlight;
            panel5.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(369, 10);
            panel5.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(0, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 10);
            panel4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lightning_McQueen;
            pictureBox1.Location = new Point(81, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 132);
            label1.Name = "label1";
            label1.Size = new Size(301, 40);
            label1.TabIndex = 7;
            label1.Text = "Pancharevo Car Rental";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            email.Location = new Point(52, 373);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(217, 36);
            email.TabIndex = 6;
            email.TextAlign = HorizontalAlignment.Center;
            email.Validating += email_Validating;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.MenuHighlight;
            panel6.Font = new Font("Segoe UI", 1.5F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.Location = new Point(52, 414);
            panel6.Name = "panel6";
            panel6.Size = new Size(369, 10);
            panel6.TabIndex = 7;
            // 
            // uppercase
            // 
            uppercase.AutoSize = true;
            uppercase.ForeColor = Color.Red;
            uppercase.Location = new Point(52, 332);
            uppercase.Name = "uppercase";
            uppercase.Size = new Size(277, 15);
            uppercase.TabIndex = 10;
            uppercase.Text = "- Password must contain at least 1 upper case letter";
            // 
            // number
            // 
            number.AutoSize = true;
            number.ForeColor = Color.Red;
            number.Location = new Point(52, 347);
            number.Name = "number";
            number.Size = new Size(229, 30);
            number.TabIndex = 11;
            number.Text = "- Password must contain at least 1 symbol\r\n\r\n";
            // 
            // len
            // 
            len.AutoSize = true;
            len.ForeColor = Color.Red;
            len.Location = new Point(51, 317);
            len.Name = "len";
            len.Size = new Size(217, 15);
            len.TabIndex = 14;
            len.Text = "- Password must be at least 8 characters\r\n";
            len.SystemColorsChanged += Password_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(177, 469);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 550);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(len);
            Controls.Add(number);
            Controls.Add(uppercase);
            Controls.Add(panel6);
            Controls.Add(email);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private BindingSource bindingSource1;
        private TextBox password;
        private TextBox username;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private TextBox email;
        private Label uppercase;
        private Label number;
        private Label len;
        private Button button2;
    }
}