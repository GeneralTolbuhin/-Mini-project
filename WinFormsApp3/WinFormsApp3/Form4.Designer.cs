namespace WinFormsApp3
{
    partial class Form4
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
            cartype = new ComboBox();
            availability = new ComboBox();
            status = new ComboBox();
            colours = new ComboBox();
            search = new Button();
            clear = new Button();
            rentacar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cartype
            // 
            cartype.FormattingEnabled = true;
            cartype.Items.AddRange(new object[] { "", "BMW M6", "Mercedes GLS", "Peugeout 206", "Opel Astra", "BMW X5", "Saab 9-3" });
            cartype.Location = new Point(86, 76);
            cartype.Name = "cartype";
            cartype.Size = new Size(121, 23);
            cartype.TabIndex = 0;
            cartype.Text = "Car type";
            // 
            // availability
            // 
            availability.FormattingEnabled = true;
            availability.Items.AddRange(new object[] { "", "full", "empty" });
            availability.Location = new Point(256, 76);
            availability.Name = "availability";
            availability.Size = new Size(121, 23);
            availability.TabIndex = 1;
            availability.Text = "Fuel status";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "", "free", "taken" });
            status.Location = new Point(427, 76);
            status.Name = "status";
            status.Size = new Size(121, 23);
            status.TabIndex = 2;
            status.Text = "Availability";
            // 
            // colours
            // 
            colours.FormattingEnabled = true;
            colours.ImeMode = ImeMode.NoControl;
            colours.Items.AddRange(new object[] { "", "black", "red", "white" });
            colours.Location = new Point(615, 76);
            colours.Name = "colours";
            colours.Size = new Size(121, 23);
            colours.TabIndex = 3;
            colours.Text = "Colours";
            // 
            // search
            // 
            search.Location = new Point(196, 287);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 4;
            search.Text = "search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // clear
            // 
            clear.Location = new Point(365, 287);
            clear.Name = "clear";
            clear.Size = new Size(75, 23);
            clear.TabIndex = 5;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // rentacar
            // 
            rentacar.Location = new Point(542, 287);
            rentacar.Name = "rentacar";
            rentacar.Size = new Size(75, 23);
            rentacar.TabIndex = 6;
            rentacar.Text = "rentacar";
            rentacar.UseVisualStyleBackColor = true;
            rentacar.Click += rentacar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(182, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(449, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(rentacar);
            Controls.Add(clear);
            Controls.Add(search);
            Controls.Add(colours);
            Controls.Add(status);
            Controls.Add(availability);
            Controls.Add(cartype);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cartype;
        private ComboBox availability;
        private ComboBox status;
        private ComboBox colour;
        private Button search;
        private Button clear;
        private Button rentacar;
        private DataGridView dataGridView1;
        private ComboBox colours;
    }
}