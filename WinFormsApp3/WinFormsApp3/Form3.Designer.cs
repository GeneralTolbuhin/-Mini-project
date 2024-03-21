namespace WinFormsApp3
{
    partial class Form3
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
            hello = new TextBox();
            pictureBox1 = new PictureBox();
            uploadBtn = new Button();
            rentacar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // hello
            // 
            hello.Location = new Point(24, 138);
            hello.Name = "hello";
            hello.Size = new Size(262, 23);
            hello.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(95, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 105);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(117, 207);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(75, 23);
            uploadBtn.TabIndex = 2;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click_1;
            // 
            // rentacar
            // 
            rentacar.Location = new Point(118, 240);
            rentacar.Name = "rentacar";
            rentacar.Size = new Size(75, 23);
            rentacar.TabIndex = 4;
            rentacar.Text = "rentacar";
            rentacar.UseVisualStyleBackColor = true;
            rentacar.Click += rentacar_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(rentacar);
            Controls.Add(uploadBtn);
            Controls.Add(pictureBox1);
            Controls.Add(hello);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hello;
        private PictureBox pictureBox1;
        private Button uploadBtn;
        private Button rentacar;
    }
}